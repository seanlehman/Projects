using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GemsGrocery.Models
{
    public class Product
    {
        public int ProdId { get; set; }
        public Double ProdPrice { get; set; }
        public int UpcCode { get; set; }
        public string ProdDesc { get; set; }
        public int InvQty { get; set; }
        public int DeptId { get; set; }
        public int PurchId { get; set; }

        public virtual ICollection<Purchase> Purchase { get; set; }
    }
}