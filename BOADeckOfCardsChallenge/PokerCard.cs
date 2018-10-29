using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOADeckOfCardsChallenge
{
    public class PokerCard
    {

        public string Suit { get; set; }

        public string Faces { get; set; }

    
    }

    
    enum Suit
    {
        Heart = 0,
        Spade = 1,
        Club = 2,
        Diamond = 3
    }

    enum Faces
    {
        Ace = 0,
        Jack = 1,
        Queen = 2,
        King = 3,
        Two = 4,
        Three = 5,
        Four = 6,
        Five = 7,
        Six = 8,
        Seven = 9,
        Eight = 10,
        Nine = 11,
        Ten = 12
    }

    
}
