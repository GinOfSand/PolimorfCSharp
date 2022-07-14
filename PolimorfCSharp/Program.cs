using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle a = new Triangle();
            Circle c = new Circle();
            Rectangle r = new Rectangle();
            CompositFigure mass = new CompositFigure(a);
            mass.AddFigure(c);
            mass.AddFigure(r);
            Console.WriteLine($"{mass.MassGF[0]} с площадью {mass.MassGF[0].AreaFigure().ToString("F2")} и периметром {mass.MassGF[0].PerimetrFigure().ToString("F2")}");
            Console.WriteLine($"{mass.MassGF[1]} с площадью {mass.MassGF[1].AreaFigure().ToString("F2")} и периметром {mass.MassGF[1].PerimetrFigure().ToString("F2")}");
            Console.WriteLine($"{mass.MassGF[2]} с площадью {mass.MassGF[2].AreaFigure().ToString("F2")} и периметром {mass.MassGF[2].PerimetrFigure().ToString("F2")}");
        }
    }
}
