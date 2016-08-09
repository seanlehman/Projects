using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GemsGrocery.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string EmpTitle { get; set; }
        public Double DeptTotSales { get; set; }
        public string ProdDesc { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}