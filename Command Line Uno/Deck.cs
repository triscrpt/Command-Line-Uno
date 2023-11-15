using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            // Store all seperate possible card values (except 0's and wild which needs to be populated more manually)
            string[] faces = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "skip", "reverse", "+2", "change colour", "+4" };
            string[] colours = { "red", "blue", "yellow", "green" };

            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            ranNum = new Random();

            // Populate the deck with cards
            PopulateDeck(colours, faces);


            // Shuffle the deck
            ShuffleDeck();
        }

        private void PopulateDeck(string[] colours, string[] faces)
        {
            // Populate the deck with cards
            int cardIndex = 0;

            // Populate colored cards
            foreach (string color in colours)
            {
                deck[cardIndex] = new Card("0", color); // Populate 0's seperately
                cardIndex++;
                for (int i = 0; i < 2; i++) // Two sets for each colored card
                {
                    foreach (string face in faces.Take(12)) // Take the next 12 faces for colored cards
                    {
                        deck[cardIndex] = new Card(face, color);
                        cardIndex++;
                    }
                }
            }

            // Populate special wild cards
            for (int i = 0; i < 4; i++) // Four of each "wild" card
            {
                foreach (string face in faces.Skip(12)) // Skip the first 12 faces for special wild cards
                {
                    deck[cardIndex] = new Card(face, "wild");
                    cardIndex++;
                }
            }
        }

        private void ShuffleDeck()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++) // Repeat for whole deck
            {
                int second = ranNum.Next(NUMBER_OF_CARDS); // Select random card
                Card temp = deck[first]; 
                deck[first] = deck[second]; // Swap current card with the randomly selected card
                deck[second] = temp;
            }
        }

        public Card DealCard()
        {
            if (currentCard < deck.Length) // Check in bounds
                return deck[currentCard++];
            else return null;
        }
    }
}
