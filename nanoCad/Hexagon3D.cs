using System;
using System.Collections.Generic;
using Multicad.DatabaseServices;
using Multicad.DatabaseServices.StandardObjects;
using Multicad.Geometry;
using Multicad.Mc3D;
using Multicad.Runtime;

namespace nanoCad
{
    public class Hexagon3D
    {
        [CommandMethod("hexagon3d", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public static void Hexagon3d()
        {
            double radius = Detal.hexRadius3d;
            double height = Detal.hexHeight3d;

            var activeSheet = McDocumentsManager.GetActiveSheet();
            Mc3dSolid detail3d = new Mc3dSolid();
            McObjectManager.Add2Document(detail3d.DbEntity, activeSheet);
            detail3d.DbEntity.AddToCurrentDocument();
            PlanarSketch sketchDetail = detail3d.AddPlanarSketch();

            List<Point3d> points = new List<Point3d>();
            for (int i = 0; i < 6; i++)
            {
                double angle = i * Math.PI / 3;
                points.Add(new Point3d(radius * Math.Cos(angle), radius * Math.Sin(angle), 0));
            }
            points.Add(points[0]);

            DbPolyline hexagon = new DbPolyline() { Polyline = new Polyline3d(points) };
            hexagon.DbEntity.AddToCurrentDocument();
            sketchDetail.AddObject(hexagon.ID);

            SketchProfile profile = sketchDetail.CreateProfile();
            profile.AutoProcessExternalContours();

            ExtrudeFeature extrudeFeature = detail3d.AddExtrudeFeature(profile.ID, height, 0, FeatureExtentDirection.Positive);
            extrudeFeature.Operation = PartFeatureOperation.Join;
            McObjectManager.UpdateAll();
        }
    }
}