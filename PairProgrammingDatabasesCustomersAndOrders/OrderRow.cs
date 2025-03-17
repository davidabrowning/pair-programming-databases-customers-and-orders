using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingDatabasesCustomersAndOrders
{
    class OrderRow
    {
        public int OrderRowId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductUnitPrice { get; set; }

        public override string? ToString()
        {
            return $"{OrderRowId}. {Product.Name}: {Product.Description} ({ProductCount} at {ProductUnitPrice} each)";
        }
    }
}
