using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOADeckOfCardsChallenge
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<PokerCard> deck = new List<PokerCard>();
            PokerCard[] initialDeck;


            CardDeck cd = new CardDeck();

            // Loading a deck with 52 cards
            initialDeck = cd.CreateDeck();

            //Shuffling the deck of cards
            PokerCard[] shuffleDeck = cd.Shuffle(initialDeck);
            
            //The following 4 lines of code can be uncommented if the user wants to display all cards of the shuffled deck 
            //for (int i = 0; i < shuffleDeck.Length; i++)
            //{
            //    Console.WriteLine(shuffleDeck[i].Faces + " of " + shuffleDeck[i].Suit + '\n');
            //}
            
             // Asking the user if they want to deal a card                      
             cd.dealOneCard(shuffleDeck);

            Console.WriteLine("No more cards to deal.");
            Console.ReadLine();

        }
    }
}
