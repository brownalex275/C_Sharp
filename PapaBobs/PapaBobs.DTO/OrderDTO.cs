using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.DTO
{

    public class OrderDTO
    {
        public System.Guid orderId { get; set; }
        public string size { get; set; }
        public string crust { get; set; }
        public string toppings { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string payment { get; set; }
        public bool completed { get; set; }
    }
}
