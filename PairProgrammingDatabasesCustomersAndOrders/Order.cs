using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingDatabasesCustomersAndOrders
{
    class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public DateTimeOffset Date { get; set; }
        virtual public List<OrderRow> OrderRows { get; set; }
    }
}
