using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingListApp.Models
{
    using System.ComponentModel.DataAnnotations;
    public class FilePath
    {
        public int FilePathId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public int ShoppingListItemId { get; set; }
        public virtual ShoppingListItem ShoppingListItem { get; set; }
    }
}