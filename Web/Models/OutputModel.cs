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
                              Name = "shorthand format strings",
                              Sublists =
                                  new List<Sublist>
                                      {
                                          new Sublist("dates", 
                                              new Pair(when, "d", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#ShortDate"), 
                                              new Pair(when, "D", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#LongDate"),
                                              new Pair(when, "m", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#MonthDay"), 
                                              new Pair(when, "M", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#MonthDay"), 
                                              new Pair(when, "y", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#YearMonth"), 
                                              new Pair(when, "Y", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#YearMonth")),
                                          new Sublist("times", 
                                              new Pair(when, "t", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#ShortTime"), 
                                              new Pair(when, "T", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#LongTime")),
                                          new Sublist("combos", 
                                              new Pair(when, "f", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#FullDateShortTime"), 
                                              new Pair(when, "F", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#FullDateLongTime"),
                                              new Pair(when, "g", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#GeneralDateShortTime"), 
                                              new Pair(when, "G", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#GeneralDateLongTime"), 
                                              new Pair(when, "o", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#Roundtrip"), 
                                              new Pair(when, "O", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#Roundtrip"), 
                                              new Pair(when, "r", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#RFC1123"), 
                                              new Pair(when, "R", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#RFC1123"), 
                                              new Pair(when, "s", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#Sortable"), 
                                              new Pair(when, "u", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#UniversalSortable"), 
                                              new Pair(when, "U", "http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#UniversalFull"))
                                      }
                          });

            Lists.Add(new List
                          {
                              Name = "custom date bits",
                              Sublists = new List<Sublist>
                                             {
                                                 new Sublist("Era", 
                                                     new Pair(when, "%g", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#gSpecifier"),
                                                     new Pair(when, "gg",  "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#ggSpecifier")),
                                                 new Sublist("year", 
                                                     new Pair(when, "yyyyy", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#yyyyySpecifier"), 
                                                     new Pair(when, "yyyy", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#yyyySpecifier"), 
                                                     new Pair(when, "yyyy", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#yyySpecifier"), 
                                                     new Pair(when, "yy", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#yySpecifier"),
                                                     new Pair(when, "y", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#ySpecifier")),
                                                 new Sublist("month", 
                                                     new Pair(when, "MMMM", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#MMMM_Specifier"), 
                                                     new Pair(when, "MMM", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#MMM_Specifier"), 
                                                     new Pair(when, "MM", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#MM_Specifier"), 
                                                     new Pair(when, "%M", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#M_Specifier")),
                                                 new Sublist("day", 
                                                     new Pair(when, "dddd", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#ddddSpecifier"), 
                                                     new Pair(when, "ddd", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#dddSpecifier"), 
                                                     new Pair(when, "dd", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#ddSpecifier"),
                                                     new Pair(when, "%d", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#dSpecifier"))
                                             }
                          });

            Lists.Add(new List
                          {
                              Name = "custom time bits",
                              Sublists = new List<Sublist>
                                             {
                                                 new Sublist("hour", 
                                                     new Pair(when, "HH", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#HH_Specifier"), 
                                                     new Pair(when, "%H", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#H_Specifier"), 
                                                     new Pair(when, "hh", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#hhSpecifier"),
                                                     new Pair(when, "%h", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#hSpecifier")),
                                                 new Sublist("minute", 
                                                     new Pair(when, "mm", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#mmSpecifier"),
                                                     new Pair(when, "%m", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#mSpecifier")),
                                                 new Sublist("second", 
                                                     new Pair(when, "ss", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#ssSpecifier"),
                                                     new Pair(when, "%s", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#sSpecifier")),
                                                 new Sublist("subsecond", 
                                                     new Pair(when, "%f",      "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#fSpecifier"),
                                                     new Pair(when, "ff",     "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#ffSpecifier"),
                                                     new Pair(when, "fff",    "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#fffSpecifier"),
                                                     new Pair(when, "ffff",   "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#ffffSpecifier"),
                                                     new Pair(when, "fffff",  "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#fffffSpecifier"),
                                                     new Pair(when, "ffffff", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#ffffffSpecifier"),
                                                     new Pair(when, "fffffff","http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#fffffffSpecifier"))
                                             }
                          });

            Lists.Add(new List
            {
                Name = "miscellaneous bits",
                Sublists = new List<Sublist>
                                             {
                                                 new Sublist("date separator", 
                                                     new Pair(when, "%/",     "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#dateSeparator")),
                                                 new Sublist("time separator", 
                                                     new Pair(when, "%:",     "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#timeSeparator")),
                                                 new Sublist("AM/PM", 
                                                     new Pair(when, "%t", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#tSpecifier"),
                                                     new Pair(when, "tt", "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#ttSpecifier")),
                                                 new Sublist("time zone", 
                                                     new Pair(when, "%K",     "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#KSpecifier"),
                                                     new Pair(when, "%z",     "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#zSpecifier"),
                                                     new Pair(when, "zz",     "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#zzSpecifier"),
                                                     new Pair(when, "zzz",    "http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx#zzzSpecifier"))
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
        public Pair(DateTime when, string formatString, string referenceUrl = null)
        {
            FormatString = formatString;
            ReferenceUrl = referenceUrl;
            Value = when.ToString(formatString);
        }

        public string FormatString { get; set; }
        public string ReferenceUrl { get; set; }
        public string Value { get; set; }
    }
}
