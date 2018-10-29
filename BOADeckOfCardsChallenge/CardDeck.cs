using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOADeckOfCardsChallenge
{
    public class CardDeck
    {
        public PokerCard[] CreateDeck()
        {
            List<PokerCard> deck = new List<PokerCard>();

            foreach (Faces face in Enum.GetValues(typeof(Faces)))
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    PokerCard card = new PokerCard();
                    card.Suit = suit.ToString();
                    card.Faces = face.ToString();
                    deck.Add(card);
                }

            }

            return deck.ToArray();
            
        }

        public PokerCard[] Shuffle (PokerCard[] deck)
          {
            Random rand = new Random();
            PokerCard[] mixedUpCards = deck;
            for (int i = 0; i < deck.Length; i++)
            {
                int randomnumber = i + rand.Next(deck.Length);

                //The following method swaps the elements of the deck array to shuffle
                mixedUpCards = Mixup(i, randomnumber, mixedUpCards);
            }
            return mixedUpCards; 
        }

        private PokerCard[] Mixup(int i, int randomnumber, PokerCard[] deck)
        {
            if (randomnumber < deck.Length)
            {
                PokerCard temp = deck.ElementAt(randomnumber);
                deck[randomnumber] = deck.ElementAt(i);
                deck[i] = temp;
            }


            return deck;
        }

        public void dealOneCard(PokerCard[] shuffleDeck)
        {
                                                       
            for (int counter = 0; counter < shuffleDeck.Length; counter++)
            {
                
                Console.WriteLine("Do you wish to deal a card? (y/n) Press Enter after selection \n");
                string selection = Console.ReadLine();
                
                
                if (selection == "y")
                {
                    Console.WriteLine(shuffleDeck[counter].Faces + " of " + shuffleDeck[counter].Suit + '\n');
                    continue;

                }
                else
                {
                    Console.WriteLine("No more cards to deal.");
                    break;
                }
            }
           

        }
    }
}
