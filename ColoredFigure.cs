using System;
using System.Collections.Generic;
using System.Text;

namespace ColoredFigure
{
    public abstract class ColoredFigure
    {
        private string color;
        protected double size;

        public ColoredFigure(string color, double size)
        {
            this.color = color;
            this.size = size;
        }

        public void Show()
        {
            Console.WriteLine($"Color is: {this.color}, Size is: {this.size}");
        }

        public string GetName()
        {
            return this.GetType().Name;
        }

        public abstract double GetArea();

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(GetName());
            result.AppendLine($"Color:{this.color}");
            result.AppendLine($"Size:{this.size:f2}");
            result.AppendLine($"Area:{this.GetArea():f2}");
            return result.ToString().TrimEnd();
        }
    }
}
