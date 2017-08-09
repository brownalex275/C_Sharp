using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime first = firstCalendar.SelectedDate;
            DateTime second = secondCalendar.SelectedDate;
            TimeSpan myTimeSpan = TimeSpan.Parse("3.4:10:50.32");
            if (first > second)
            {
                myTimeSpan = first.Subtract(second);
                resultLabel.Text = myTimeSpan.TotalDays.ToString();
            }
            else if (second > first)
            {
                myTimeSpan = second.Subtract(first);
                resultLabel.Text = myTimeSpan.TotalDays.ToString();
            }
            else
            {
                myTimeSpan = first.Subtract(second);
                resultLabel.Text = myTimeSpan.TotalDays.ToString();
            }
            resultLabel.Text = myTimeSpan.TotalDays.ToString();

        }
    }
}