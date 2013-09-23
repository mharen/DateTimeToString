using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class OutputModel
    {
        public DateTime Now { get; set; }
        public List<List> Lists { get; set; }

        public OutputModel(DateTime when)
        {
            Now = when;
            Lists = new List<List>();

            Lists.Add(new List
                          {
                              Name = "shorthand/standard strings",
                              Sublists =
                                  new List<Sublist>
                                      {
                                          new Sublist
                                              {
                                                  Name = "dates",
                                                  Pairs = new List<Pair>
                                                              {
                                                                  new Pair(when, "d"),
                                                                  new Pair(when, "D"),
                                                                  new Pair(when, "m"),
                                                                  new Pair(when, "y")
                                                              }
                                              },
                                          new Sublist
                                              {
                                                  Name = "times",
                                                  Pairs = new List<Pair>
                                                              {
                                                                  new Pair(when, "t"),
                                                                  new Pair(when, "T")
                                                              }
                                              },
                                          new Sublist
                                              {
                                                  Name = "combos",
                                                  Pairs = new List<Pair>
                                                              {
                                                                  new Pair(when, "f"),
                                                                  new Pair(when, "F"),
                                                                  new Pair(when, "g"),
                                                                  new Pair(when, "G"),
                                                                  new Pair(when, "o"),
                                                                  new Pair(when, "R"),
                                                                  new Pair(when, "s"),
                                                                  new Pair(when, "u"),
                                                                  new Pair(when, "U")
                                                              }
                                              }
                                      }
                          });

            Lists.Add(new List
            {
                Name = "custom dates bits",
                Sublists = new List<Sublist> {
                                    new Sublist{
                                        Name = "year",
                                        Pairs = new List<Pair>{
                                            new Pair(when, "yyyy"),
                                            new Pair(when, "yy")
                                        }
                                    },
                                    new Sublist{
                                        Name= "month",
                                        Pairs = new List<Pair>{
                                            new Pair(when, "MM"),
                                            new Pair(when, "%M")
                                        }
                                    },
                                    new Sublist{
                                        Name= "day",
                                        Pairs = new List<Pair>{
                                            new Pair(when, "ddd"),
                                            new Pair(when, "dd"),
                                            new Pair(when, "%d")
                                        }
                                    }
                                }
            });
            Lists.Add(new List
                          {
                              Name = "custom time bits",
                              Sublists = new List<Sublist>
                                             {
                                                 new Sublist
                                                     {
                                                         Name = "hour",
                                                         Pairs = new List<Pair>
                                                                     {
                                                                         new Pair(when, "HH"),
                                                                         new Pair(when, "hh")
                                                                     }
                                                     },
                                                 new Sublist
                                                     {
                                                         Name = "minute",
                                                         Pairs = new List<Pair>
                                                                     {
                                                                         new Pair(when, "mm")
                                                                     }
                                                     },
                                                 new Sublist
                                                     {
                                                         Name = "second",
                                                         Pairs = new List<Pair>
                                                                     {
                                                                         new Pair(when, "ss")
                                                                     }
                                                     }
                                             }
                          });
        }
    }

    public class List
    {
        public string Name { get; set; }
        public List<Sublist> Sublists { get; set; }
    }

    public class Sublist
    {
        public string Name { get; set; }
        public List<Pair> Pairs { get; set; }
    }

    public class Pair
    {
        public Pair(DateTime when, string formatString)
        {
            FormatString = formatString;
            Value = when.ToString(formatString);
        }

        public string FormatString { get; set; }
        public string Value { get; set; }
    }
}
