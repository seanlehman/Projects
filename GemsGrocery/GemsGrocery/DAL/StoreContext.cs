using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GemsGrocery.Models;

namespace GemsGrocery.DAL
{
    public class StoreContext : DbContext
    {

        public StoreContext() : base("StoreContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNamesConvention>();
        }

    }
}