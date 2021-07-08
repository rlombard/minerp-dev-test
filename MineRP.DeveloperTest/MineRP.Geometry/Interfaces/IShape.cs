namespace MineRP.Geometry.Interfaces
{
    public interface IShape
    {
        double Area();
        double Circumference();
        bool CanCalculate();
        int NumberOfPoints();
        string Print();
    }
}
