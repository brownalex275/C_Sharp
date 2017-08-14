using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Bob Tabor";
            // In my case, the result would be:
            // robaT boB
            string reverse = "";
            for (int i = name.Length  ; i-- > 0;)
            {

                reverse += name[i];
                resultLabel.Text = reverse;
            }
            


            

            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            string[] split = names.Split(',');
            reverse = "";
            string result = "";
            for (int i = split.Length; i-- > 0;)
            {

                reverse += split[i] + ",";

                
            }
            result = reverse.Remove(reverse.Length - 1);
            resultLabel0.Text = result;


            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***
            int length = 14;
          
            string stars = "";
            for (int i = 0; i < split.Length; i++)
            
            {
                int space = length - split[i].Length;
                int padLeft = space / 2 + split[i].Length;
                stars += split[i].PadLeft(padLeft, '*').PadRight(length,'*') + "<br />";
            }

            resultLabel1.Text = stars;
    
           

            
            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            string remove = "remove-me";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            string replace = puzzle.Replace('Z','T');
     
            string takeOut = replace.Remove(replace.IndexOf(remove), remove.Length);

            string lower = takeOut.ToLower();

            result = char.ToUpper(lower[0]) + lower.Substring(1);

            resultLabel2.Text = result;
                

            /*for (int i = 0; i < puzzle.Length; i++)

            {
                

            } */
        }
    }
}