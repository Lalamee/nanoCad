using System;
using System.Collections.Generic;
using Multicad.DatabaseServices;
using Multicad.DatabaseServices.StandardObjects;
using Multicad.Geometry;
using Multicad.Mc3D;
using Multicad.Runtime;

namespace nanoCad
{
    public class Hexagon2D
    {
        [CommandMethod("hexagon2d", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public static void Hexagon2d()
        {
            double radius = Detal.hexRadius2d;

            var activeSheet = McDocumentsManager.GetActiveSheet();
            Mc3dSolid detail2d = new Mc3dSolid();
            McObjectManager.Add2Document(detail2d.DbEntity, activeSheet);
            detail2d.DbEntity.AddToCurrentDocument();
            PlanarSketch sketchDetail = detail2d.AddPlanarSketch();

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

            McObjectManager.UpdateAll();
        }
    }
}