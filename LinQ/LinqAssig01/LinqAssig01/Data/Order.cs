using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLect01.Data
{
    internal class Order
    {

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public Order(int orderId, DateTime orderDate, decimal total)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            Total = total;
        }

        public Order() { }
    }
}
