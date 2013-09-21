using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Web.Models;

namespace Web.Controllers
{
    public class DataController : ApiController
    {
        public OutputModel Get()
        {
            var when = DateTime.UtcNow;
            var model = new OutputModel(when);

            return model;
        }

        private IEnumerable<string> GetDateString()
        {
            return new[]
                       {
                           "yyyy", "yy",
                           "MM", "M",
                           "ddd", "dd", "d"
                       };
        }
        
        private IEnumerable<string> GetTimeStrings()
        {
            return new[]
                       {
                           "HH", "hh",
                           "mm",
                           "ss"
                       };
        }
    }
}
