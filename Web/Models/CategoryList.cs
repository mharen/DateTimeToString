using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class CategoryList
    {
        public string Category { get; set; }
        public IEnumerable<Item> Items { get; set; } 
    }
}