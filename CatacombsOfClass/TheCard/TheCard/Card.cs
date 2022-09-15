using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCard
{
    internal class Card
    {
        readonly string CC;
        readonly string CR;

        public Card(string _CC, string _CR)
        {
            CC = _CC;
            CR = _CR;
        }

        public void DetermineCard()
        {
            Console.WriteLine($"The {CC} {CR}");
        }

    }
}
