using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GemsGrocery.Models
{
    public class Customer
    {
        public int CustId { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime PurchDate { get; set; }
        public int PurchId { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}