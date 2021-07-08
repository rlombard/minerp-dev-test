using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MineRP.Geometry.Interfaces;

namespace MineRP.Geometry
{
    public class Shape : IShape
    {
        public List<Point2D> Points { get; }

        public Shape(IEnumerable<Point2D> points)
        {
            Points = points.ToList();
        }

        /// <summary>
        /// Calculates the Area of the Shape
        /// </summary>
        /// <returns>Area of Shape</returns>
        public virtual double Area()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the Circumference of the Shape
        /// </summary>
        /// <returns>Circumference of Shape</returns>
        public virtual double Circumference()
        {
            throw new NotImplementedException();
        }

        public virtual bool CanCalculate()
        {
            return NumberOfPoints() > 2;
        }

        public int NumberOfPoints()
        {
            return Points.Count;
        }

        public string Print()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Number of Points: {NumberOfPoints()}");
            stringBuilder.AppendLine($"Can Calculate: {CanCalculate()}");
            stringBuilder.AppendLine($"Circumference: {Circumference()}");
            stringBuilder.AppendLine($"Area: {Area()}");
            return stringBuilder.ToString();
        }
    }
}
