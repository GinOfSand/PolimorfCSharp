using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfCSharp
{
    internal class CompositFigure
    {
        public GeometryF[] MassGF;
        public CompositFigure(GeometryF massGF)
        {
            MassGF = new GeometryF[1];
            MassGF[0] = massGF;
        }
        public void AddFigure(GeometryF a) {
            GeometryF[] mass = new GeometryF[MassGF.Length + 1];
            for (int i = 0; i < MassGF.Length; i++)
            {
                mass[i] = MassGF[i];
            }
            MassGF = mass;
            MassGF[MassGF.Length-1] = a;
        }
    }
}
