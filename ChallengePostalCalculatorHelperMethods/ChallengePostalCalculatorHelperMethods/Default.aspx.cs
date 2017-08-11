using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void calculateTotal(double width, double height, double length = 1.0 )
        {
            if (TextBox3.Text != String.Empty) length = double.Parse(TextBox3.Text);

            double cost = width * height * length;

            if (groundRadioButton.Checked)
            {
                cost *= .15;
                resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", cost);

            }
            else if (airRadioButton.Checked)
            {
                cost *= .25;
                resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", cost);
            }
            else if (nextRadioButton.Checked)
            {
                cost *= .45;
                resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", cost);
            }

            
        }
        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));

               
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text != String.Empty && TextBox2.Text != String.Empty)
                calculateTotal(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
        }

        protected void nextRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text != String.Empty && TextBox2.Text != String.Empty)
                calculateTotal(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text != String.Empty && TextBox2.Text != String.Empty)
                calculateTotal(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text != String.Empty && TextBox2.Text != String.Empty)
                calculateTotal(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text != String.Empty && TextBox2.Text != String.Empty)
                calculateTotal(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
        }
    }
}