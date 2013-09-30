using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace Web.Models
{
    public class IndexModel
    {
        public int SelectedCultureId { get; set; }
        public IList<SelectListItem> Cultures { get; set; }
    }
}