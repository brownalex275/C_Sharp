using System;
using Darts;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        public int score1 { get; set; }
        public int score2 { get; set; }
        Dart player1 = new Dart();
        Dart player2 = new Dart();
        Random random = new Random();
        public void play()
        {


            while (this.score1 < 300 & this.score2 < 300)
            {
                int i = 0;

                while (i < 3)
                {
                    player1.Throw(random);
                    this.score1 += Score.calculateScore(player1);
                    player2.Throw(random);
                    this.score2 += Score.calculateScore(player2);
                    i++;


                }



            }


        }
        public string result()
        {
            string result = "";
            if (this.score1 > this.score2) result = String.Format("Player 1: {0}<br />Player 2: {1}<br /> Player 1 wins!", this.score1, this.score2);
            else if (this.score1 < this.score2) result = String.Format("Player 1: {0}<br />Player 2: {1}<br /> Player 2 wins!", this.score1, this.score2);
            else result = String.Format("Player 1: {0}<br />Player 2: {1}<br /> It's a tie!", this.score1, this.score2);

            return result;
        }
    }
}