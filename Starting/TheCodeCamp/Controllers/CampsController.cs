using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TheCodeCamp.Controllers
{
    public class CampsController :ApiController
    {
        public object Get()
        {
            return new {Name = "Francis", Occupation = "Developer"};
        }
    }
}
