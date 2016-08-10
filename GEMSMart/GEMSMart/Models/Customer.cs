using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GEMSMart.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int PurchaseId { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}