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
            model.Cultures = CultureInfo.GetCultures(CultureTypes.AllCultures)
                                        .OrderBy(c => c.DisplayName)
                                        .Select(c => new SelectListItem
                                                         {
                                                             Text = c.DisplayName,
                                                             Value = c.LCID.ToString(CultureInfo.InvariantCulture)
                                                         })
                                        .ToList();

            model.TimeZones = TimeZoneInfo.GetSystemTimeZones()
                                          .OrderBy(tz => tz.BaseUtcOffset)
                                          .Select(tz => new SelectListItem
                                                            {
                                                                Text = tz.DisplayName,
                                                                Value = tz.Id
                                                            })
                                          .ToList();

            Utilities.LoadUserDefaultCultureWhereNecessary(model, Request.UserLanguages.FirstOrDefault());
            return View(model);
        }


    }
}
