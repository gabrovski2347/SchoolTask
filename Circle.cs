using System;
using System.Collections.Generic;
using System.Text;

namespace ColoredFigure
{
    public class Circle : ColoredFigure
    {
        public Circle(string color, double size) 
            : base(color, size)
        {
        }

        public override double GetArea()
        {
            double area = Math.PI * size * size;
            return area;
        }
    }
}
