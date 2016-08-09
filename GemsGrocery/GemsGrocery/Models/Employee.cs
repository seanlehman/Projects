using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GemsGrocery.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpLastName { get; set; }
        public string EmpFirstMidName { get; set; }
        public DateTime EmpHire { get; set; }
        public int DeptId { get; set; }
        public string EmpTitle { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}