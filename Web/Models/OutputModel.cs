using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class OutputModel
    {
        public OutputModel(DateTime when)
        {
            Lists = new List<BigList>
                        {
                            new BigList
                                {
                                    Title = "Dates",
                                    CategoryLists = new List<CategoryList>
                                                        {
                                                            new CategoryList
                                                                {
                                                                    Category = "Year",
                                                                    Items = new Item[]
                                                                                {
                                                                                    new Item(when, "yyyy"),
                                                                                    new Item(when, "yy")
                                                                                }
                                                                },
                                                            new CategoryList
                                                                {
                                                                    Category = "Month",
                                                                    Items = new Item[]
                                                                                {
                                                                                    new Item(when, "MMM"),
                                                                                    new Item(when, "MM"),
                                                                                    new Item(when, "M")
                                                                                }
                                                                },
                                                            new CategoryList
                                                                {
                                                                    Category = "Day",
                                                                    Items = new Item[]
                                                                                {
                                                                                    new Item(when, "dd"),
                                                                                    new Item(when, "d")
                                                                                }
                                                                }
                                                        }
                                }
                        };
        }

        public List<BigList> Lists { get; set; } 
    }
}