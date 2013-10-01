using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using Web.Models;

namespace Web.Controllers
{
    public class DataController : ApiController
    {
        public OutputModel Get([FromUri] IndexModel indexModel)
        {
            Utilities.LoadUserDefaultCultureWhereNecessary(indexModel, Request.Headers.AcceptLanguage.Select(h=>h.Value).FirstOrDefault());

            var culture = CultureInfo.GetCultureInfo(indexModel.SelectedCultureId);
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;

            var when = DateTime.UtcNow;
            var whenInZone = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(when, indexModel.SelectedTimeZoneId);
            var model = new OutputModel(whenInZone);

            return model;
        }
    }
}
