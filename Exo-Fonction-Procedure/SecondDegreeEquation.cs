using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Fonction_Procedure
{
    public struct SecondDegreeEquation
    {
        public double A;
        public double B;
        public double C;

        public SecondDegreeEquation (double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool Resoudre(out double? x1, out double? x2)
        {
            double determinant = Math.Pow(B, 2) - 4 * A * C;

            if (determinant < 0)
            {
                x1 = null;
                x2 = null;
                return false;
            } 
            else if (determinant == 0)
            {
                x1 = (B * -1) / (2 * A);
                x2 = null;
                return true;
            }
            else
            {
                x1 = ((B * -1) - Math.Sqrt(determinant)) / (2 * A);
                x2 = ((B * -1) + Math.Sqrt(determinant)) / (2 * A);
                return true;
            }
        }
    }
}
