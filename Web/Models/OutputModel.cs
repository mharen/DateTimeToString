using System;
using System.Collections.Generic;
using System.Globalization;
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
                                          new Sublist("dates", new Pair(when, "d"), new Pair(when, "D"),
                                                      new Pair(when, "m"), new Pair(when, "y")),
                                          new Sublist("times", new Pair(when, "t"), new Pair(when, "T")),
                                          new Sublist("combos", new Pair(when, "f"), new Pair(when, "F"),
                                                      new Pair(when, "g"), new Pair(when, "G"), new Pair(when, "o"),
                                                      new Pair(when, "R"), new Pair(when, "s"), new Pair(when, "u"),
                                                      new Pair(when, "U"))
                                      }
                          });

            Lists.Add(new List
                          {
                              Name = "custom dates bits",
                              Sublists = new List<Sublist>
                                             {
                                                 new Sublist("year", new Pair(when, "yyyy"), new Pair(when, "yy")),
                                                 new Sublist("month", new Pair(when, "MM"), new Pair(when, "%M")),
                                                 new Sublist("day", new Pair(when, "ddd"), new Pair(when, "dd"),
                                                             new Pair(when, "%d"))
                                             }
                          });

            Lists.Add(new List
                          {
                              Name = "custom time bits",
                              Sublists = new List<Sublist>
                                             {
                                                 new Sublist("hour", new Pair(when, "HH"), new Pair(when, "hh")),
                                                 new Sublist("minute", new Pair(when, "mm")),
                                                 new Sublist("second", new Pair(when, "ss"))
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
        public Sublist(string name, params Pair[] pairs)
        {
            Name = name;
            Pairs = pairs;
        }

        public string Name { get; set; }
        public Pair[] Pairs { get; set; }
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
