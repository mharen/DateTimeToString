using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class BigList
    {
        public string Title { get; set; }
        public IEnumerable<CategoryList> CategoryLists { get; set; } 
    }
}