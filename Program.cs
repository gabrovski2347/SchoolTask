using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ColoredFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var figures = new List<ColoredFigure>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var typeName = tokens[0];
                var color = tokens[1];
                var size = double.Parse(tokens[2]);

                if (typeName == "Circle")
                {
                    figures.Add(new Circle(color, size));
                }
                else if (typeName == "Square")
                {
                    figures.Add(new Square(color, size));
                }
                else
                {
                    figures.Add(new Triangle(color, size));
                }

            }

            foreach (var item in figures)
            {
                Console.WriteLine(item);
            }
        }
    }
}
