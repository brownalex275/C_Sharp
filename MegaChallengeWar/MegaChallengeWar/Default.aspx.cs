using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeWar
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            var Deck = new Deck();
            var rand = new Random();
            var cards = new Card();
            List<Player> players;
            string dealResult;
            string cardResult;
            string result = "";
            var deck = cards.InitializeCards();


            resultLabel0.Text = "Dealing cards...";
            Deck.Deal(deck, rand, out players, out dealResult);

            result += dealResult;
            var games = new Game();

            games.IsFaceCard(players, out cardResult);
            result += cardResult;

            resultLabel.Text = result;
            
            

        }
    }
}