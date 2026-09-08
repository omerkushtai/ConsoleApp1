using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle(5);
            Shape shape2 = new Rectangle { Width = 4, Height = 6 };
            Shape shape3 = new Triangle(3, 4, 5, 6);
            List<Shape> shapes = new List<Shape> { shape1, shape2, shape3 };
            foreach (Shape shape in shapes){
                Console.WriteLine(shape.ToString());
                Console.WriteLine($"Area: {shape.GetArea()}");
                Console.WriteLine($"Perimeter: {shape.GetPerimeter()}");
                Console.WriteLine();
            }
            Dictionary<string, Shape> shapeDictionary = new Dictionary<string, Shape>();
            foreach (Shape shape in shapes)
            {
                shapeDictionary.Add(shape.ToString(), shape);
            }
            foreach (KeyValuePair<string, Shape> item in shapeDictionary)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
   
}