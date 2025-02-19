using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LinqLect01.Data
{
     class Customer
    {
        public string CustomerId { get; set; }
        public string CustomrName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Phones { get; set; }
        public string Fax { get; set; }
        public Order[] Orders { get; set; }

        public Customer(string CustomerID , string CustomerName)
        {
            CustomerId = CustomerID;
            CustomrName = CustomerName;
            Orders = new Order[10];
        }

        public Customer()
        {

        }

        public override string ToString()
        {
            return $"{CustomerId}, {CustomrName}, {Address}, {City}, {Region}, {PostCode}, {Country}, {Phones}, {Fax}";
        }
    }
}
