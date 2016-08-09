using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GemsGrocery.Models
{
    public class Purchase
    {
        public int PurchId { get; set; }
        public int CustId { get; set; }
        public int ProdId { get; set; }
        public Double ProdPrice { get; set; }
        public int ProdQty { get; set; }
        public string ProdDesc { get; set; }
        public int TotSale { get; set; }
        public DateTime PurchDate { get; set; }
        public int EmpId { get; set; }
        public int DeptId { get; set; }

       

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Department Department { get; set; }

    }
}