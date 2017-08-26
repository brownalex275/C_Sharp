using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Deck
    {
        
        public List<Card> Cards { get; set; }

        public void Deal(List<Card> cards, Random rand, out List<Player> players, out string dealResult)
        {
            var player1 = new Player { name = "player1",deck = new List<Card>() };
            var player2 = new Player { name = "player2", deck = new List<Card>() };

            List<Player> gamers = new List<Player>();

            var randomOrder = cards.OrderBy(i => rand.Next());

            List<Card> shuffledCards = new List<Card>();

            foreach (var item in randomOrder)
            {

                shuffledCards.Add(item);

            }


            var num = 0;
            var dealtCards = "";

            foreach (var card in shuffledCards)
            {
                if (num % 2 == 0)
                {
                    player1.deck.Add(card);
                    if (card.faceCard != null) dealtCards += String.Format("{0} is dealt the {1} of {2}<br />", player1.name,card.faceCard, card.cardSuite);
                  
                    else dealtCards += String.Format("{0} is dealt the {1} of {2}<br />", player1.name, card.cardNum, card.cardSuite);
                }

                else
                {
                   
                    player2.deck.Add(card);
                    if (card.faceCard != null) dealtCards += String.Format("{0} is dealt the {1} of {2}<br />", player2.name, card.faceCard, card.cardSuite);
                    
                    else dealtCards += String.Format("{0} is dealt the {1} of {2}<br />", player2.name, card.cardNum, card.cardSuite);
                }

                num += 1;
            }
            gamers.Add(player1);
            gamers.Add(player2);

            players = gamers;
            dealResult = dealtCards;

            
        }

        
    }

    
}