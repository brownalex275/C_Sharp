using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeCasino
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double money = 100;
                string[] images = new string[12] { "~/Bar.png", "~/Bell.png","~/Cherry.png","~/Clover.png","~/Diamond.png","~/HorseShoe.png","~/Lemon.png","~/Orange.png",
                "~/Plum.png","~/Seven.png","~/Strawberry.png","~/Watermellon.png"};
                Image1.ImageUrl = images[random.Next(1, 12)];
                Image2.ImageUrl = images[random.Next(1, 12)];
                Image3.ImageUrl = images[random.Next(1, 12)];

                moneyLabel.Text = String.Format("Player's Money {0:C}", money);

                ViewState.Add("money", money);
                ViewState.Add("images", images);
            }
        }

        private void spinReel()
        {

            string[] images = (string[])ViewState["images"];

            string firstImage = images[random.Next(1, 12)];
            string secondImage = images[random.Next(1, 12)];
            string thirdImage = images[random.Next(1, 12)];

            setImages(firstImage,secondImage,thirdImage);

        }

        private void setImages(string firstImage, string  secondImage, string thirdImage)
        {
            Image1.ImageUrl = firstImage;
            Image2.ImageUrl = secondImage;
            Image3.ImageUrl = thirdImage;

            oneCherry(firstImage, secondImage, thirdImage);

        }

        private void oneCherry(string firstImage, string secondImage, string thirdImage)
        {
            if (firstImage != "~/Bar.png" && secondImage != "~/Bar.png" && thirdImage != "~/Bar.png")
            {
                if (firstImage == "~/Cherry.png" || secondImage == "~/Cherry.png" || thirdImage == "~/Cherry.png")
                {
                    int multiplier = 2;
                    twoCherries(firstImage, secondImage, thirdImage, multiplier);
                }
                else sevens(firstImage, secondImage, thirdImage);
            }

            else bar();
        }

        private void twoCherries(string firstImage, string secondImage, string thirdImage, int multiplier)
        {
            if ((firstImage == "~/Cherry.png" && secondImage == "~/Cherry.png") || (firstImage == "~/Cherry.png" && thirdImage == "~/Cherry.png")
                || (secondImage == "~/Cherry.png" && thirdImage == "~/Cherry.png"))
            {
                multiplier = 3;
                threeCherries(firstImage, secondImage, thirdImage, multiplier);
            }
            else bet(multiplier);

        }

        private void threeCherries(string firstImage, string secondImage, string thirdImage, int multiplier)
        {
            if ((firstImage == secondImage) && (firstImage == thirdImage))
            {
                multiplier = 4;
                bet(multiplier);

            }
            else bet(multiplier);
        }   
        


        private void sevens(string firstImage, string secondImage, string thirdImage)
        {
            int multiplier = 0;
            if ((firstImage == secondImage) && (firstImage == thirdImage))
            {
                multiplier = 100;
            }
            else bet(multiplier);
        }

        private void bar()
        {
            int multiplier = 0;
            bet(multiplier);
        }

        private void bet(int multiplier)
        {
           
            double bet = double.Parse(TextBox1.Text);
            double money = (double)ViewState["money"] - bet;
            double winnings = bet * multiplier;
            double result = 0;

            outcome(bet, money, winnings,result);
           

            
        }

        private void outcome(double bet, double money, double winnings, double result)
        {
         
            if (winnings != 0)
            {
                result = winnings + money;
                showOutcome(bet,winnings, result);
            }
            else
            {
                result = money;
                showOutcome(bet, winnings, result);

            }


        }

        private void showOutcome(double bet, double winnings, double result)
        {
            if (winnings == 0)
            {
                resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time.", bet);
                showMoney(result);
            }
            else
            {
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, winnings);
                showMoney(result);
            }
        }

        private void showMoney(double result)
        {
            moneyLabel.Text = String.Format("Player's Money: {0:C}", result);
            ViewState["money"] = result;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double money = (double)ViewState["money"];
            if (money > 0) spinReel();
            else resultLabel.Text = "INSUFFICIENT FUNDS";
        }

    }
}