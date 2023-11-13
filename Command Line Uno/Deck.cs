using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Line_Uno
{
    internal class Deck
    {
        private Card[] deck;
        private int currentCard;
        private const int NUMBER_OF_CARDS = 108;
        private Random ranNum;

        public Deck()
        {
            string[] faces = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "skip", "reverse", "+2", "change colour", "+4" };
            string[] colours = { "red", "blue", "yellow", "green", "wild" };

            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            ranNum = new Random();


            for (int i = 0; i < deck.Length; i++)
            {
                for (int j = 0; j < j; j++)
                {
                    deck[i] = new Card(faces[i], colours[j]);

                }

            }
        }
    }
}
