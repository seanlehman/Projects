using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GEMSMart.Models;

namespace GEMSMart.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var customers = new List<Customer>
            {
            new Customer{FirstMidName="Carson",LastName="Alexander",PurchaseDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstMidName="Meredith",LastName="Alonso",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstMidName="Arturo",LastName="Anand",PurchaseDate=DateTime.Parse("2003-09-01")},
            new Customer{FirstMidName="Gytis",LastName="Barzdukas",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstMidName="Yan",LastName="Li",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstMidName="Peggy",LastName="Justice",PurchaseDate=DateTime.Parse("2001-09-01")},
            new Customer{FirstMidName="Laura",LastName="Norman",PurchaseDate=DateTime.Parse("2003-09-01")},
            new Customer{FirstMidName="Nino",LastName="Olivetto",PurchaseDate=DateTime.Parse("2005-09-01")}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
            new Product{ProductId=1050,ProductDesc="Bread",ProductPrice=2.29,},
            new Product{ProductId=4022,ProductDesc="Milk",ProductPrice=4.99,},
            new Product{ProductId=4041,ProductDesc="Soda",ProductPrice=4.59,},
            new Product{ProductId=1045,ProductDesc="Diapers",ProductPrice=9.99,},
            new Product{ProductId=3141,ProductDesc="Napkins",ProductPrice=2.39,},
            new Product{ProductId=2021,ProductDesc="Juice",ProductPrice=3.99,},
            new Product{ProductId=2042,ProductDesc="Butter",ProductPrice=3.69,}
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var purchases = new List<Purchase>
            {
            new Purchase{CustomerId=1,ProductId=1050,ProductPrice=2.29},
            new Purchase{CustomerId=1,ProductId=4022,ProductPrice=4.99},
            new Purchase{CustomerId=1,ProductId=4041,ProductPrice=4.59},
            new Purchase{CustomerId=2,ProductId=1045,ProductPrice=9.99},
            new Purchase{CustomerId=2,ProductId=3141,ProductPrice=2.39},
            new Purchase{CustomerId=2,ProductId=2021,ProductPrice=3.99},
            new Purchase{CustomerId=3,ProductId=2042,ProductPrice=3.69},
            new Purchase{CustomerId=4,ProductId=1050,ProductPrice=2.29},
            new Purchase{CustomerId=4,ProductId=4022,ProductPrice=4.99},
            new Purchase{CustomerId=5,ProductId=4041,ProductPrice=4.59},
            new Purchase{CustomerId=6,ProductId=1045,ProductPrice=9.99},
            new Purchase{CustomerId=7,ProductId=3141,ProductPrice=2.39},
            };                                                                      
            purchases.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();
        }
    }
}