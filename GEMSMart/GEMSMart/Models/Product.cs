using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace GEMSMart.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }
        public string ProductDesc { get; set; }
        public Double ProductPrice { get; set; }
        public virtual ICollection<Purchase> Purchase { get; set; }
    }
}