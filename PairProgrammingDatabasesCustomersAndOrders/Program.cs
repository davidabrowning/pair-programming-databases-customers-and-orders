using Microsoft.EntityFrameworkCore;

namespace PairProgrammingDatabasesCustomersAndOrders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramDbContext dbCtx = new ProgramDbContext();

            //dbCtx.Add(new Customer()
            //{
            //    Name = "Jane Roe",
            //    Email = "jane.roe@example.com"
            //});
            //dbCtx.Customers.SaveChanges();

            //Product product1 = new Product();
            //product1.Name = "Coffee mug";
            //product1.Description = "A nice coffee mug to use for coffee in the morning.";
            //product1.UnitPrice = 35.00M;
            //dbCtx.Products.Add(product1);
            //dbCtx.SaveChanges();

            //Product product2 = new Product();
            //product2.Name = "Coffee beans";
            //product2.Description = "Coffee beans to grind and brew at home.";
            //product2.UnitPrice = 88.00M;
            //dbCtx.Products.Add(product2);
            //dbCtx.SaveChanges();

            //Order order = new Order();
            //order.Customer = dbCtx.Customers.FirstOrDefault<Customer>();
            //order.Date = DateTimeOffset.Now;
            //dbCtx.Orders.Add(order);
            //dbCtx.SaveChanges();

            //Order order = dbCtx.Orders.FirstOrDefault<Order>();
            //Product product1 = dbCtx.Products.Where(p => p.ProductId == 1).FirstOrDefault();
            //Product product2 = dbCtx.Products.Where(p => p.ProductId == 2).FirstOrDefault();

            //OrderRow row1 = new OrderRow();
            //row1.Order = order;
            //row1.Product = product1;
            //row1.ProductCount = 4;
            //row1.ProductUnitPrice = product1.UnitPrice;
            //dbCtx.OrderRows.Add(row1);
            //dbCtx.SaveChanges();

            //OrderRow row2 = new OrderRow();
            //row2.Order = order;
            //row2.Product = product2;
            //row2.ProductCount = 2;
            //row2.ProductUnitPrice = product2.UnitPrice;
            //dbCtx.OrderRows.Add(row2);
            //dbCtx.SaveChanges();

            Console.WriteLine("Printing all customers:");
            foreach (Customer customer in dbCtx.Customers
                .Include(c => c.Orders)
                .ThenInclude(o => o.OrderRows)
                .ThenInclude(or => or.Product))
            {
                Console.WriteLine(customer);
            }

        }
    }
}
