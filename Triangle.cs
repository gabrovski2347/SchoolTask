using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ColoredFigure
{
    public class Triangle : ColoredFigure
    {
        public Triangle(string color, double size) 
            : base(color, size)
        {
        }

        public override double GetArea()
        {
            double area = ((this.size * this.size) * Math.Sqrt(3)) / 4;
            return area;
        }
    }
}
