using System;
using Newtonsoft.Json;

namespace MineRP.Geometry
{
    /// <summary>
    /// 2 Dimensional Point
    /// </summary>
    public struct Point2D
    {
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// X-Coordinate
        /// </summary>
        [JsonProperty("x")]
        public double X { get; set; }

        /// <summary>
        /// X-Coordinate
        /// </summary>
        [JsonProperty("y")]
        public double Y { get; set; }

        /// <summary>
        /// Determine Distance between this point and another
        /// </summary>
        /// <param name="point">Other point</param>
        /// <returns>Distance</returns>
        public double DistanceTo(Point2D point)
        {
            throw new NotImplementedException();
        }
    }
}
