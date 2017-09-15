using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain
{
    public class OrderManager
    {
       

        
        public static object GetOrders()
        {
            return Persistence.OrdersRepository.GetOrders();
        }

        public static void CompleteOrder(Guid orderId)
        {
            Persistence.OrdersRepository.CompleteOrder(orderId);
        }

        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            if (orderDTO.name.Trim().Length == 0)
                throw new Exception("Name is a required field.");

            if (orderDTO.phone.Trim().Length == 0)
                throw new Exception("Phone number is a required field.");

            if (orderDTO.payment == "")
                throw new Exception("Please select a payment method. ");

            if (orderDTO.toppings == "")
                throw new Exception("Please select at least one topping.");

            if (orderDTO.address.Trim().Length == 0)
                throw new Exception("Address is a required field.");

            if (orderDTO.zip.Trim().Length == 0)
                throw new Exception("Zip Code is a required field.");

            orderDTO.orderId = Guid.NewGuid();
            Persistence.OrdersRepository.CreateOrder(orderDTO);



        }
    }
}
