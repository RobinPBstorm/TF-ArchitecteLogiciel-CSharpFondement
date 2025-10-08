using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Enum
{
    [Flags]
    public enum Vehicule
    {
        None = 0,
        Vélo = 1,
        Voiture = 2,
        Bus = 4,
        Trotinette = 8,
    }
}
