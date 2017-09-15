using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace PapaBobs.Persistence
{
    public class OrdersRepository
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            var db = new NewDBEntities();

            var order = convertToEntity(orderDTO);

            try
            {
                db.Orders.Add(order);
                db.SaveChanges();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public static Order convertToEntity(DTO.OrderDTO orderDTO)
        {
            var order = new Order();

            order.orderId = orderDTO.orderId;
            order.size = orderDTO.size;
            order.toppings = orderDTO.toppings;
            order.crust = orderDTO.crust;
            order.address = orderDTO.address;
            order.name = orderDTO.name;
            order.payment = orderDTO.payment;
            order.phone = orderDTO.phone;
            order.zip = orderDTO.zip;
            order.completed = orderDTO.completed;

            return order;

        }

        public static List<DTO.OrderDTO> GetOrders()
        {
            var db = new NewDBEntities();

            var orders = db.Orders.Where(p => p.completed == false).ToList();

            var ordersDTO = convertToDTO(orders);

            return ordersDTO;


        }

        private static List<DTO.OrderDTO> convertToDTO(List<Order> orders)
        {
            var ordersDTO = new List<DTO.OrderDTO>();

            foreach (var order in orders)
            {
                var orderDTO = new DTO.OrderDTO();

                orderDTO.orderId = order.orderId;
                orderDTO.size =  order.size;
                orderDTO.toppings = order.toppings;
                orderDTO.crust = order.crust;
                orderDTO.address = order.address;
                orderDTO.name = order.name;
                orderDTO.payment = order.payment;
                orderDTO.phone = order.phone;
                orderDTO.zip = order.zip;
                orderDTO.completed = order.completed;
                ordersDTO.Add(orderDTO);

            }
            return ordersDTO;
        }

        public static void CompleteOrder(Guid OrderId)
        {
            var db = new NewDBEntities();
            var order = db.Orders.FirstOrDefault(p => p.orderId == OrderId);
            order.completed = true;
            db.SaveChanges();
        }

        

           

        



    }
            
    }