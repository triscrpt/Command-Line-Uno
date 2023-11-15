using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Line_Uno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            for (int i = 0; i < deck.deckLength; i++)
                Console.WriteLine(deck.DealCard());

            Console.ReadKey();
        }
    }
}
