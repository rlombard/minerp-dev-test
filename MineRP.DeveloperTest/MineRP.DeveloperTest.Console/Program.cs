using System;
using System.Collections.Generic;
using MineRP.Geometry;
using MineRP.Geometry.Interfaces;

namespace MineRP.DeveloperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>();

            for (var i = 1; i <= 5; i++)
            {
                var points = PointReader.GetPoints(i.ToString());
                var shape = new Shape(points);

                shapes.Add(shape);
            }

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Print());
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
