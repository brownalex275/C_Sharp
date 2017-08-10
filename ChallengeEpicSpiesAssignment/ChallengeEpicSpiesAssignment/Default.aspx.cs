using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
            DateTime today = DateTime.Now.Date;
            prevCalendar.SelectedDate = today;
            startCalendar.SelectedDate = today.AddDays(14);
            endCalendar.SelectedDate = today.AddDays(21);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TimeSpan time = startCalendar.SelectedDate.Subtract(prevCalendar
                .SelectedDate);
            if (time.Days >= 14)
            {
                TimeSpan moreTime = endCalendar.SelectedDate.Subtract(startCalendar.SelectedDate);
                double total = moreTime.Days * 500;
                
                if (moreTime.Days > 21)
                {
                    total += 1000;

                    
                   
                }
                string result = String.Format("Assignment of {0} to assignment {1}" +
                        " is authorized. Budget total: {2:C}", spyTextBox.Text, assignTextBox.Text, total);

                resultLabel.Text = result;
            }
            else
            {
                resultLabel.Text = "Error: Must be at least two weeks between " +
                    "previous assignment and new assignment ";

                startCalendar.SelectedDate = prevCalendar.SelectedDate.AddDays(14);
            }

        }
    }
}