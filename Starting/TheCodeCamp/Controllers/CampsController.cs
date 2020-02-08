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
        public IHttpActionResult Get()
        {
            //return BadRequest("Not really bad. Just testing");
            return Ok(new {Name = "Francis", Occupation = "Developer"});
        }
    }
}
