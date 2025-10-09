using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Enum.Models
{
    public struct Deck
    {
        public List<Card> Cards;

        public Deck()
        {
            Fill();
            Shuffle();
        }

        public void Fill()
        {
            Cards = new List<Card>();
            foreach (Value value in Enum.GetValues<Value>())
            {
                foreach (Color color in Enum.GetValues<Color>())
                {
                    Cards.Add(new Card(color, value));
                }
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < Cards.Count() * 4; i++)
            {
                int index1 = random.Next(Cards.Count);

                int index2;
                do
                {
                    index2 = random.Next(Cards.Count);
                } while (index2 == index1);

                Card temp = Cards[index2];
                Cards[index2] = Cards[index1];
                Cards[index1] = temp;
            }
        }
    }
}
