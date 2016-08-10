using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GemsGrocery.Models;

namespace GEMSGrocery.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var customers = new List<Customer>
            {
            new Customer{FirstMidName="Carson",LastName="Alexander",PurchDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstMidName="Meredith",LastName="Alonso",PurchDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstMidName="Arturo",LastName="Anand",PurchDate=DateTime.Parse("2003-09-01")},
            new Customer{FirstMidName="Gytis",LastName="Barzdukas",PurchDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstMidName="Yan",LastName="Li",PurchDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstMidName="Peggy",LastName="Justice",PurchDate=DateTime.Parse("2001-09-01")},
            new Customer{FirstMidName="Laura",LastName="Norman",PurchDate=DateTime.Parse("2003-09-01")},
            new Customer{FirstMidName="Nino",LastName="Olivetto",PurchDate=DateTime.Parse("2005-09-01")}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var product = new List<Product>
            {
            new Product{ProdId=1050,ProdDesc="Bread",ProdPrice=2.29,UpcCode=1234567890,InvQty=20,},
            new Product{ProdId=4022,ProdDesc="Milk",ProdPrice=4.99,UpcCode=1234567891,InvQty=15,},
            new Product{ProdId=4041,ProdDesc="Soda",ProdPrice=4.59,UpcCode=1234567892,InvQty=4,},
            new Product{ProdId=1045,ProdDesc="Diapers",ProdPrice=9.99,UpcCode=1234567893,InvQty=32,},
            new Product{ProdId=3141,ProdDesc="Napkins",ProdPrice=2.39,UpcCode=1234567894,InvQty=21,},
            new Product{ProdId=2021,ProdDesc="Juice",ProdPrice=3.99,UpcCode=1234567895,InvQty=45,},
            new Product{ProdId=2042,ProdDesc="Butter",ProdPrice=3.69,UpcCode=1234567896,InvQty=12,}
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var purchases = new List<Purchase>
            {
            new Purchase{CustId=1,ProdId=1050,PurchDate=DateTime.Parse("2016-06-01")},
            new Purchase{CustId=1,ProdId=4022,PurchDate=DateTime.Parse("2016-06-01")},
            new Purchase{CustId=1,ProdId=4041,PurchDate=DateTime.Parse("2016-06-01")},
            new Purchase{CustId=2,ProdId=1045,PurchDate=DateTime.Parse("2016-06-01")},
            new Purchase{CustId=2,ProdId=3141,PurchDate=DateTime.Parse("2016-06-02")},
            new Purchase{CustId=2,ProdId=2021,PurchDate=DateTime.Parse("2016-06-02")},
            new Purchase{CustId=3,ProdId=2042,PurchDate=DateTime.Parse("2016-06-02")},
            new Purchase{CustId=4,ProdId=1050,PurchDate=DateTime.Parse("2016-06-02")},
            new Purchase{CustId=4,ProdId=4022,PurchDate=DateTime.Parse("2016-06-03")},
            new Purchase{CustId=5,ProdId=4041,PurchDate=DateTime.Parse("2016-06-03")},
            new Purchase{CustId=6,ProdId=1045,PurchDate=DateTime.Parse("2016-06-03")},
            new Purchase{CustId=7,ProdId=3141,PurchDate=DateTime.Parse("2016-06-03")},
            };
            purchases.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();
        }
    }
}