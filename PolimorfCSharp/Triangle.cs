using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfCSharp
{
    internal class Triangle : GeometryF
    {
        double wall1 { get; set; }
        double wall2 { get; set; }

        double wall3 { get; set; }

        public Triangle(double wall1 = 3, double wall2 = 3, double wall3 = 3)
        {
            this.wall1 = wall1;
            this.wall2 = wall2;
            this.wall3 = wall3;
        }

        public override double PerimetrFigure()
        {
            return wall1 + wall2 + wall3;
        }
        public override double AreaFigure()
        {
            double p = (wall1 + wall2 + wall3) / 2;
            return Math.Sqrt(p*(p - wall1)*(p-wall2)*(p-wall3));
        }
        public override string ToString()
        {
            return $"Триугольник со сторонами {wall1}, {wall2}, {wall3}";
        }
    }
}
