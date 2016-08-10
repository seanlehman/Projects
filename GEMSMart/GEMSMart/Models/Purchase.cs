using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GEMSMart.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public Double ProductPrice { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }


    }
}