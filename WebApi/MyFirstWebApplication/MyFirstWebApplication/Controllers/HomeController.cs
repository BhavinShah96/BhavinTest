using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyFirstWebApplication.Controllers
{
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Get is Working");
        }

        [HttpPost]
        public IHttpActionResult Post()
        {
            return Ok("Post is Working");
        }

        [HttpPut]
        public IHttpActionResult Put()
        {
            return Ok("Put is Working");
        }


    }
}