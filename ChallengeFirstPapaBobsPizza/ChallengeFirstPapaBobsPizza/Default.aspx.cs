using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsPizza
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double total = 0.00;
            if (babyRadioButton.Checked)
            {
                total = 10.00;
            }
            else if (mamaRadioButton.Checked)
            {
                total = 13.00;
            }
            else if (papaRadioButton.Checked)
            {
                total = 16.00;
            }



            if (deepRadioButton.Checked)
            {
                total += 2.00;
            }

            if (pepperoniCheckBox.Checked)
            {
                total += 1.50;
            }
            if (onionsCheckBox.Checked)
            {
                total += 0.75;
            }
            if (greenCheckBox.Checked)
            {
                total += 0.50;
            }
            if (redCheckBox.Checked)
            {
                total += 0.75;
            }
            if (anchoviesCheckBox.Checked)
            {
                total += 2.00;
            }


            if ((pepperoniCheckBox.Checked && greenCheckBox.Checked && anchoviesCheckBox.Checked)
                || (pepperoniCheckBox.Checked && redCheckBox.Checked && onionsCheckBox.Checked))
            {
                total -= 2.00;
            }

            resultLabel.Text = total.ToString();
            
        
        }
    }
}