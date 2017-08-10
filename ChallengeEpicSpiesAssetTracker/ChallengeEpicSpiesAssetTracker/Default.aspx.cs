using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] names = new string[0];
                int[] elections = new int[0];
                int[] acts = new int[0];
                ViewState.Add("names", names);
                ViewState.Add("elections", elections);
                ViewState.Add("acts", acts);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] names = (string[])ViewState["names"];
            int[] elections = (int[])ViewState["elections"];
            int[] acts = (int[])ViewState["acts"];

            Array.Resize(ref names, names.Length + 1);
            Array.Resize(ref elections, elections.Length + 1);
            Array.Resize(ref acts, acts.Length + 1);

            int newestItem = names.GetUpperBound(0);

            names[newestItem] = TextBox1.Text;
            elections[newestItem] = int.Parse(TextBox2.Text);
            acts[newestItem] = int.Parse(TextBox3.Text);

            ViewState["names"] = names;
            ViewState["elections"] = elections;
            ViewState["acts"] = acts;

            resultLabel.Text = String.Format("Total Elections Rigged: {0} <br /> Average Acts of Subterfuge per Asset: {1:N2} <br />" +
                " (Last Asset you Added: {2})", elections.Sum(), acts.Average(), names[newestItem]);

        }
    }
}