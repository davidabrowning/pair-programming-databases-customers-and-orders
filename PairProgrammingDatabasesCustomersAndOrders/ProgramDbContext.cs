﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingDatabasesCustomersAndOrders
{
    class ProgramDbContext : DbContext
    {
        // private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PairProgrammingCustomersAndOrders;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderRow> OrderRows { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlServer(new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetSection("ConnectionStrings")["ApplicationDb"]);

            // Logging variant 1
            optionsBuilder.UseLoggerFactory(
                new LoggerFactory(new[]
                {
                    new DebugLoggerProvider()
                }));
            
            // Logging variant 2
            // optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}
