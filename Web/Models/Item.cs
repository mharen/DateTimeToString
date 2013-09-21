using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Item
    {
        public Item(DateTime when, string formatString)
        {
            FormatString = formatString;
            Value = when.ToString(formatString);
        }

        public string FormatString { get; set; }
        public string Value { get; set; }
    }
}