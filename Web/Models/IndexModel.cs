using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Web.Mvc;

namespace Web.Models
{
    public class IndexModel
    {
        public IndexModel()
        {
            // defaults
            SelectedCultureId = 1033; // en-US
            SelectedTimeZoneId = "UTC";
        }

        public int SelectedCultureId { get; set; }
        public IList<SelectListItem> Cultures { get; set; }

        public string SelectedTimeZoneId { get; set; }
        public IList<SelectListItem> TimeZones { get; set; }
    }
}