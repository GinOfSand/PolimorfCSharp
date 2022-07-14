using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfCSharp
{
    internal class Rectangle : GeometryF
    {
        public double height { get; set; }
        public double width { get; set; }

        public Rectangle(double height =4, double width = 2)
        {
            this.height = height;
            this.width = width;
        }
       public override double PerimetrFigure() 
        {
            return (height + width) * 2 ; 
        }

        public override double AreaFigure()
        {
            return height * width;
        }
        public override string ToString()
        {
            return $"Прямоугольник с выстой {height} и шириной {width}";
        }
    }
}
