﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListTeam3.Data
{
    public class Note
    {
        [Key]
        public int ID { get; set; }
        /*
         A better approach for 0..1-One Relationship
         Remove ID
         Set ItemID to be both Key and Foreign Key
         Add Navigation Property to both sides
        */
        //[Key]
        //[ForeignKey("Item")] "Item" shoould be the name of the navigation property
        public int ItemId { get; set;}
        public string Body { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }

        public virtual Item Item { get; set; }
    }
}
