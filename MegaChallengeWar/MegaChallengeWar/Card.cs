using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Card
    {
        public int cardNum { get; set; }
        public string cardSuite { get; set; }
        public string faceCard { get; set; }

        public List<Card> InitializeCards()
        {
            var i = 2;
            List<Card> cards = new List<Card>();
            while (i <= 14)
            {

                cards.Add(new Card { cardNum = i, cardSuite = "Spades" });
                cards.Add(new Card { cardNum = i, cardSuite = "Hearts" });
                cards.Add(new Card { cardNum = i, cardSuite = "Diamonds" });
                cards.Add(new Card { cardNum = i, cardSuite = "Clubs" });
                i++;
            };

            foreach (var card in cards )
            {
                if (card.cardNum == 11) card.faceCard = "Jack";
                else if (card.cardNum == 12) card.faceCard = "Queen";
                else if (card.cardNum == 13) card.faceCard = "King";
                else if (card.cardNum == 14) card.faceCard = "Ace";
                
            }
            

            return cards;
        }
    }
}