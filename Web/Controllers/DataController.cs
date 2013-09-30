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
        public OutputModel Get(int selectedCultureId = 1033 /* en-us */)
        {
            var culture = CultureInfo.GetCultureInfo(selectedCultureId);
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;

            var when = DateTime.UtcNow;
            var model = new OutputModel(when);

            return model;
        }
    }
}
