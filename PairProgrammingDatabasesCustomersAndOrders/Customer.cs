using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PairProgrammingDatabasesCustomersAndOrders
{
    [Table("Customers", Schema ="people")]
    class Customer
    {
        public int CustomerId { get; set; }
        [Column("CustomerFullName")]
        public string Name { get; set; }
        public string Email { get; set; }
        virtual public List<Order> Orders { get; set; } = new List<Order>();

        public override string ToString()
        {
            string customerString = $"{CustomerId}. {Name} ({Email})";
            foreach (Order order in Orders)
            {
                customerString += $"\n\t{order}";
            }
            return customerString;
        }
    }
}
