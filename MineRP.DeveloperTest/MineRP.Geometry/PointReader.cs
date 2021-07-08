using System.Collections.Generic;
using System.IO;
using System.Reflection;
using MineRP.Geometry.Exceptions;
using Newtonsoft.Json;

namespace MineRP.Geometry
{
    public static class PointReader
    {
        /// <summary>
        /// Get points from embedded file
        /// </summary>
        /// <param name="pointFileName"></param>
        /// <returns></returns>
        public static List<Point2D> GetPoints(string pointFileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"MineRP.Geometry.Files.{pointFileName}.json";

            using var stream = assembly.GetManifestResourceStream(resourceName);
            if (stream == null) throw new EmbeddedFileNotFoundException();

            using var reader = new StreamReader(stream);
            var json = reader.ReadToEnd();

            return JsonConvert.DeserializeObject<List<Point2D>>(json);
        }
    }

       
}
