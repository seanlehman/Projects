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
            new Product{ProdID=1050,ProdDesc="Bread",ProdPrice=2.29,UpcCode=1234567890,InvQty=20,},
            new Product{ProdID=4022,ProdDesc="Milk",ProdPrice=4.99,UpcCode=1234567890,InvQty=15,},
            new Product{ProdID=4041,ProdDesc="Soda",ProdPrice=4.59,UpcCode=1234567890,InvQty=4,},
            new Product{ProdID=1045,ProdDesc="Diapers",ProdPrice=9.99,UpcCode=1234567890,InvQty=32,},
            new Product{ProdID=3141,ProdDesc="Napkins",ProdPrice=2.39,UpcCode=1234567890,InvQty=21,},
            new Product{ProdID=2021,ProdDesc="Juice",ProdPrice=3.99,UpcCode=1234567890,InvQty=45,},
            new Product{ProdID=2042,ProdDesc="Butter",ProdPrice=3.69,UpcCode=1234567890,InvQty=12,}
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var purchases = new List<Purchase>
            {
            new Purchase{CustID=1,ProdID=1050,Grade=Grade.A},
            new Purchase{CustID=1,ProdID=4022,Grade=Grade.C},
            new Purchase{CustID=1,ProdID=4041,Grade=Grade.B},
            new Purchase{CustID=2,ProdID=1045,Grade=Grade.B},
            new Purchase{CustID=2,ProdID=3141,Grade=Grade.F},
            new Purchase{CustID=2,ProdID=2021,Grade=Grade.F},
            new Purchase{CustID=3,ProdID=2042,Grade=Grade.F},
            new Purchase{CustID=4,ProdId=1050,Grade=Grade.F},
            new Purchase{CustID=4,ProdId=4022,Grade=Grade.F},
            new Purchase{CustID=5,ProdId=4041,Grade=Grade.C},
            new Purchase{CustID=6,ProdId=1045,Grade=Grade.F},
            new Purchase{CustID=7,ProdId=3141,Grade=Grade.A},
            };
            purchases.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();
        }
    }
}