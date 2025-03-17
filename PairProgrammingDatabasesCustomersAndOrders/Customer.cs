using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingDatabasesCustomersAndOrders
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        virtual public List<Order> Orders { get; set; } = new List<Order>();

        public override string? ToString()
        {
            string customerString = $"{CustomerId}. {Name} ({Email})";
            foreach (Order order in Orders)
            {
                customerString += $"\n     {order}";
            }
            return customerString;
        }
    }
}
