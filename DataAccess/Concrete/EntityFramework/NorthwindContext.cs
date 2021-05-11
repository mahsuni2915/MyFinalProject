using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework//DAta base tanıttık
{
    public class NorthwindContext:DbContext // DbContext EntitiyFrameworkun verdiği bir contextdir
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order>Orders { get; set; }

    }
}
