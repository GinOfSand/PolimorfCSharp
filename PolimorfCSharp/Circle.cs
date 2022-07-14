using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfCSharp
{
    internal class Circle : GeometryF
    {
        public double Radius { get; set; }

        public Circle(double radius = 2)
        {
            Radius = radius;
        }

        public override double PerimetrFigure()
        {
            return 2*Math.PI*Radius;
        }
        public override double AreaFigure()
        {
            return Math.PI * (Radius * Radius);
        }
        public override string ToString()
        {
            return $"Окружность с радиусом {Radius}";
        }
    }
}
