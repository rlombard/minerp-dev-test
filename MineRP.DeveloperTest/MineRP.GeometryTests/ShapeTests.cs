using Xunit;

namespace MineRP.Geometry.Tests
{
    public class ShapeTests
    {
        [Fact()]
        public void AreaTest()
        {

        }

        [Fact()]
        public void CircumferenceTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void CanCalculateTest()
        {
            var points = PointReader.GetPoints("3");
            var triangle = new Shape(points);
            Assert.True(triangle.CanCalculate(), "Not enough points to determine a 2D shape");
        }

        [Fact()]
        public void NumberOfPointsTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}