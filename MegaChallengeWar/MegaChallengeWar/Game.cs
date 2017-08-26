using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Game
    {
        public void IsFaceCard(List<Player> gamers, out string cardResult)
        {
            var i = 0;
            
            cardResult = "";
            List<Player> battlePlayers;
            string battleResult;
            List<Player> warPlayers;
            string warResult;

           
            
            
      

                while (i <= 20)
                {
                    var player1 = gamers[0].deck[0];
                    var player2 = gamers[1].deck[0];
                    List<Card> warPlayer1;
                    List<Card> warPlayer2;

                    if (player1.cardNum == player2.cardNum)
                    {
                        
                        War(gamers[0].deck, gamers[1].deck, out warPlayer1, out warPlayer2, out warResult);
                        gamers[0].deck = warPlayer1;
                        gamers[1].deck = warPlayer2;

                        cardResult += warResult;
                    }

                    else
                    {
                        if (player1.faceCard != null && player2.faceCard == null)
                        {
                            cardResult += String.Format("<br />Battle Cards: {0} of {1} versus {2} of {3}<br />", player1.faceCard, player1.cardSuite, player2.cardNum, player2.cardSuite);
                            cardResult += String.Format("Bounty...<br />&nbsp;&nbsp;{0} of {1}<br />&nbsp;&nbsp;{2} of {3}<br />", player1.faceCard, player1.cardSuite, player2.cardNum, player2.cardSuite);
                            
                        }

                        else if (player1.faceCard == null && player2.faceCard != null)
                        {
                            cardResult += String.Format("<br />Battle Cards: {0} of {1} versus {2} of {3}<br />", player1.cardNum, player1.cardSuite, player2.faceCard, player2.cardSuite);
                            cardResult += String.Format("Bounty...<br />&nbsp;&nbsp;{0} of {1}<br />&nbsp;&nbsp;{2} of {3}<br />", player1.cardNum, player1.cardSuite, player2.faceCard, player2.cardSuite);
                            
                        }

                        else
                        {
                            cardResult += String.Format("<br />Battle Cards: {0} of {1} versus {2} of {3}<br />", player1.cardNum, player1.cardSuite, player2.cardNum, player2.cardSuite);
                            cardResult += String.Format("Bounty...<br />&nbsp;&nbsp;{0} of {1}<br />&nbsp;&nbsp;{2} of {3}<br />", player1.cardNum, player1.cardSuite, player2.cardNum, player2.cardSuite);
                            
                        }

                        Battle(gamers, out battlePlayers, out battleResult);
                        gamers = battlePlayers;
                        cardResult += battleResult;

                    
                    }
                    i++;
                }

                 if (gamers[0].deck.Count > gamers[1].deck.Count) cardResult += String.Format("<br /><font color=\"red\"><b>Player 1 wins</b></font><br />" +
                 "<font color=\"red\"><b>Player 1: {0}</b></font><br /><font color =\"blue\"><b>Player 2: {1}</b></font><br />",gamers[0].deck.Count, gamers[1].deck.Count);

                 else cardResult += String.Format("<br /><font color=\"blue\"><b>Player 2 wins</b></font><br />" +
                 "<font color=\"red\"><b>Player 1: {0}</b></font><br /><font color =\"blue\"><b>Player 2: {1}</b></font><br />",gamers[0].deck.Count, gamers[1].deck.Count);



        }

        public void Battle(List<Player> players, out List<Player> battlePlayers, out string battleResult)

           
        {
            var player1 = players[0].deck[0];
            var player2 = players[1].deck[0];


            if (player1.cardNum > player2.cardNum)
            {
                battleResult = "<b>Player1 Wins!</b><br />";
                players[0].deck.Add(player2);
                players[1].deck.Remove(player2);

                battlePlayers = players;

            }

            else 
            {
                battleResult = "<b>Player2 Wins!</b><br />";
                players[1].deck.Add(player1);
                players[0].deck.Remove(player1);

                battlePlayers = players;

            }
            
        }
           

        public void War(List<Card> player1, List<Card> player2, out List<Card> warPlayer1, out List<Card> warPlayer2, out string warResult)
        {
            List<Card> player1Cards = new List<Card>();
            List<Card> player2Cards = new List<Card>();
            var bounty = "Bounty...<br />";
           

            for (int i = 0; i < 4; i++)
            {
                if (player1[i].faceCard != null)
                {
                    player1Cards.Add(player1[i]);
                    bounty += String.Format("&nbsp;&nbsp;{0} of {1}<br />", player1[i].faceCard, player1[i].cardSuite);
                   
                }

                else
                {
                    player1Cards.Add(player1[i]);
                    bounty += String.Format("&nbsp;&nbsp;{0} of {1}<br />", player1[i].cardNum, player1[i].cardSuite);
                }
                
            }

            for (int i = 0; i < 4; i++)
            {
                if (player2[i].faceCard != null)
                {
                    player2Cards.Add(player2[i]);
                    bounty += String.Format("&nbsp;&nbsp;{0} of {1}<br />", player2[i].faceCard, player2[i].cardSuite);

                }

                else
                {
                    player2Cards.Add(player2[i]);
                    bounty += String.Format("&nbsp;&nbsp;{0} of {1}<br />", player2[i].cardNum, player2[i].cardSuite);
                }



            }

            if (player1Cards[0].faceCard != null && player2Cards[0].faceCard == null) warResult = String.Format("<br />Battle Cards: {0} of {1} " +
                "versus {2} of {3}<br />", player1Cards[0].faceCard, player1Cards[0].cardSuite, player2Cards[0].cardNum, player2Cards[0].cardSuite);
            else if (player1Cards[0].faceCard == null && player2Cards[0].faceCard != null) warResult = String.Format("<br />Battle Cards: {0} of {1} " +
                "versus {2} of {3}<br />", player1Cards[0].cardNum, player1Cards[0].cardSuite, player2Cards[0].faceCard, player2Cards[0].cardSuite);


            else warResult = String.Format("<br />Battle Cards: {0} of {1} " +
                "versus {2} of {3}<br />", player1Cards[0].cardNum, player1Cards[0].cardSuite, player2Cards[0].cardNum, player2Cards[0].cardSuite);

            warResult += "*********WAR*********<br />";
            warResult += bounty;

            if (player1Cards[3].cardNum > player2Cards[3].cardNum)
            {
                warResult += "<b>Player1 Wins!</b><br />";

                foreach (var card in player2Cards)
                {
                    player1.Add(card);
                    player2.Remove(card);
                }
            }
            else if (player2Cards[3].cardNum > player1Cards[3].cardNum)
            {
                warResult += "<b>Player2 Wins!</b><br />";

                foreach (var card in player1Cards)
                {
                    player2.Add(card);
                    player1.Remove(card);
                }
            }



            warPlayer1 = player1;
            warPlayer2 = player2;


           
        }
    }
}