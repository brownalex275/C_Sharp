using System;
using Darts;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static int calculateScore(Dart player)
        {
            int score = player.points;
            if (player.band == "outer band") score *= 2;
            if (player.band == "inner band") score *= 3;
            if (player.band == "outer bullseye") score = 25;
            if (player.band == "inner bullseye") score = 50;
            return score;
        }
    }

}