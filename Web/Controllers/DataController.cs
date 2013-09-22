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
    }
}
