using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                noteImage.ImageUrl = "~/pencil.png";
            }
            else if (penRadioButton.Checked)
            {
                noteImage.ImageUrl = "~/pen.png";
            }
            else if (phoneRadioButton.Checked)
            {
                noteImage.ImageUrl = "~/phone.png";
            }
            else if (tabletRadioButton.Checked)
            {
                noteImage.ImageUrl = "~/tablet.png";
            }
            else
            {
                resultLabel.Text = "Please select an option.";
            }
        }

    }
}