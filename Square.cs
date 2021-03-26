using System;
using System.Collections.Generic;
using System.Text;

namespace ColoredFigure
{
    public class Square : ColoredFigure
    {
        public Square(string color, double size) 
            : base(color, size)
        {
        }

        public override double GetArea()
        {
            double area = size * size;
            return area;
        }
    }
}
