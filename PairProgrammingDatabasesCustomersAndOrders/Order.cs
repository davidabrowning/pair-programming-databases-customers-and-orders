using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingDatabasesCustomersAndOrders
{
    class Order
    {
        public int OrderId { get; set; } = 0;
        public Customer Customer { get; set; } = new Customer();
        public DateTimeOffset Date { get; set; }
        virtual public List<OrderRow> OrderRows { get; set; } = new List<OrderRow>();
        virtual public decimal TotalPrice {
            get {
                decimal totalPrice = 0M;
                foreach (var row in OrderRows)
                {
                    totalPrice += row.ProductUnitPrice * row.ProductCount;
                }
                return totalPrice;
            }
        }

        public override string ToString()
        {
            string orderString = $"Order {OrderId}. {Date} TOTAL: {TotalPrice}";
            foreach (OrderRow orderRow in OrderRows)
            {
                orderString += $"\n\t\t{orderRow}";
            }
            return orderString;
        }
    }
}
