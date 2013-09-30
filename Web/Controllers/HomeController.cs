using System;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(IndexModel model)
        {
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures)
                                      .Select(c => new SelectListItem
                                                       {
                                                           Text = c.DisplayName,
                                                           Value = c.LCID.ToString(CultureInfo.InvariantCulture)
                                                       })
                                      .OrderBy(c => c.Text);

            model.Cultures = cultures.ToList();

            if (model.SelectedCultureId == 0)
            {
                model.SelectedCultureId = 1033; // en-us
            }
            return View(model);
        }
    }
}
