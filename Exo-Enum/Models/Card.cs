using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Enum.Models
{
    public struct Card
    {
        public Color Color;
        public Value Value;

        public Card(Color color, Value value)
        {
            Color = color;
            Value = value;
        }
    }
}
