using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobs
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (pizzaDropDownList.SelectedValue != "none" && crustDropDownList.SelectedValue != "none")
            calculateTotal();
         
           
        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
           
            var newOrder = new DTO.OrderDTO();

            newOrder.name = nameTextBox.Text;
            newOrder.orderId = Guid.NewGuid();


            newOrder.size = pizzaDropDownList.SelectedItem.Text;

            newOrder.phone = phoneTextBox.Text;

            if (credit.Checked)
                newOrder.payment = credit.ID;
            else newOrder.payment = cash.ID;

           
            var toppings = "";

            if (sausage.Checked) toppings += "sausage, ";
            if (pepperoni.Checked) toppings += "pepperoni, " ;
            if (onions.Checked) toppings += "onions, ";
            if (greenpeppers.Checked) toppings += "green peppers, ";

            toppings = toppings.Remove(toppings.Length - 2);

            newOrder.toppings = toppings;

            newOrder.address = addressTextBox.Text;
          
            newOrder.crust = crustDropDownList.SelectedItem.Text;

            newOrder.zip = zipTextBox.Text;

            newOrder.completed = false;


            try
            {
                Domain.OrderManager.CreateOrder(newOrder);
                Server.Transfer("Success.aspx", true);


            }
            catch (Exception ex)
            {

                resultLabel.Text = ex.Message;
            }



        }

        private void calculateTotal()
        {
            
            double total = 0.0;

            total += double.Parse(pizzaDropDownList.SelectedValue);
            total += double.Parse(crustDropDownList.SelectedValue);

            if (sausage.Checked) total += 2.0;
            if (pepperoni.Checked) total += 1.50;
            if (onions.Checked) total += 1;
            if (greenpeppers.Checked) total += 1;

            

            costLabel.Text = String.Format("{0:C}", total);

        }
        
    }

}