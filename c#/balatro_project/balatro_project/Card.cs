using System;
using System.Collections.Generic;
using System.Text;

namespace balatro_project
{
    class Card
    {
        string number;

        Suits suit;

        public Card(string number, Suits suit)
        {
            this.number = number;
            this.suit = suit;
            
            this.suit = suit.DIAMONDS;
            this.Value = Value.ACE;

        }

        public int Printme()
        {
            Console.WriteLine(this.suit + this.number);
            return 1;
        }
    }
}
