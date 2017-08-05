using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(firstValueTextBox.Text);
            int j = int.Parse(secondValueTextBox.Text);
            int result = i + j;
            resultLabel.Text = result.ToString();

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void sub_btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(firstValueTextBox.Text);
            int j = int.Parse(secondValueTextBox.Text);
            int result = i - j;
            resultLabel.Text = result.ToString();
        }

        protected void mult_btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(firstValueTextBox.Text);
            int j = int.Parse(secondValueTextBox.Text);
            int result = i * j;
            resultLabel.Text = result.ToString();
        }

        protected void div_btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(firstValueTextBox.Text);
            int j = int.Parse(secondValueTextBox.Text);
            double result = (double)i / (double)j;
            resultLabel.Text = result.ToString();
        }
    }
}