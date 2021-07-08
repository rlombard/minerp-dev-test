using Xunit;
using MineRP.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineRP.Geometry.Tests
{
    public class PointReaderTests
    {
        [Fact()]
        public void GetPointsTest()
        {
            var points = PointReader.GetPoints("3");
            Assert.True(points.Count == 3);
        }
    }
}