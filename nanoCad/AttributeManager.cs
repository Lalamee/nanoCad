using System;
using System.IO;
using System.Xml.Serialization;
using Multicad.AplicationServices;

namespace nanoCad
{
    public class AttributeManager
    {
        public class Attributes
        {
            public double HexRadius2d { get; set; }
            public double HexRadius3d { get; set; }
            public double HexHeight3d { get; set; }
        }

        public static void ImportAttributes(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Attributes));
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        Attributes attrs = (Attributes)serializer.Deserialize(fs);
                        Detal.hexRadius2d = attrs.HexRadius2d;
                        Detal.hexRadius3d = attrs.HexRadius3d;
                        Detal.hexHeight3d = attrs.HexHeight3d;
                    }
                    McContext.ShowNotification("Атрибуты успешно импортированы.");
                }
                catch (Exception ex)
                {
                    McContext.ShowNotification($"Ошибка при импорте атрибутов: {ex.Message}");
                }
            }
            else
            {
                McContext.ShowNotification("Файл не найден.");
            }
        }

        public static void ExportAttributes(string filePath)
        {
            try
            {
                Attributes attrs = new Attributes
                {
                    HexRadius2d = Detal.hexRadius2d,
                    HexRadius3d = Detal.hexRadius3d,
                    HexHeight3d = Detal.hexHeight3d
                };

                XmlSerializer serializer = new XmlSerializer(typeof(Attributes));
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    serializer.Serialize(fs, attrs);
                }
                McContext.ShowNotification("Атрибуты успешно экспортированы.");
            }
            catch (Exception ex)
            {
                McContext.ShowNotification($"Ошибка при экспорте атрибутов: {ex.Message}");
            }
        }
    }
}
