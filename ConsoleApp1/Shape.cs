
using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    public abstract class Shape
    {
        private static int _counter;
        private int _id;
        public Shape()
        {
            _counter++;
            _id = ++_counter;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString()
        {
            return $"Shape ID: {_id}";
        }
    }
}