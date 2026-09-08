
namespace ConsoleApp1
{
    public class Circle : Shape, IRollable
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public void Roll()
        {
            Console.WriteLine($"Rolling the circle ");
        }
    }
}