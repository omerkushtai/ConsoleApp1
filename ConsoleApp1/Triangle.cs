
namespace ConsoleApp1
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Triangle(double baseLength, double height, double sideA, double sideB)
        {
            Base = baseLength;
            Height = height;
            SideA = sideA;
            SideB = sideB;
        }
        public Triangle()
        {
            Base = 1;
            Height = 1;
            SideA = 1;
            SideB = 1;
        }

        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }

        public override double GetPerimeter()
        {
            return Base + SideA + SideB;
        }
    }
}