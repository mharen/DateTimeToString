using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web
{
    public class Utilities
    {
        public static void LoadUserDefaultCultureWhereNecessary(IndexModel model, string language)
        {
            if (model.SelectedCultureId != 0 || string.IsNullOrEmpty(language))
            {
                return;
            }

            try
            {
                var userCulture = CultureInfo.GetCultureInfo(language);
                model.SelectedCultureId = userCulture.LCID;
            }
            catch (CultureNotFoundException)
            {
                model.SelectedCultureId = 1033; // default to en-us 
            }
        }
    }
}