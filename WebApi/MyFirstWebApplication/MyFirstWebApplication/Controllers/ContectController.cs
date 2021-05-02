using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using MyFirstWebApplication.Models;
using MyFirstWebApplication.Service;
using MyFirstWebApplication.DTO;

namespace MyFirstWebApplication.Controllers
{
    public class ContectController : ApiController
    {
        ContectService service = new ContectService();
        public IHttpActionResult GetContect()
        {

            return Ok(service.getContects());
        }

        [HttpPost]
        public IHttpActionResult Post(ContectDTO conDTO)
        {
            service.ADD(conDTO);
            return Ok("Post is Working");
        }

        [HttpPut]
        public IHttpActionResult Put(ContectDTO contectDTO)
        {
            Contect contect = service.GetContectByID(contectDTO);
            contect.ID = contectDTO.ID;
            contect.Name = contectDTO.Name;
            contect.MobileNo = contectDTO.MobileNo;
            contect.Address = contectDTO.Address;
            return Ok("Put is Working");
        }

        [HttpDelete]
        public IHttpActionResult Delete(ContectDTO contectDTO)
        {
            service.DelContect(contectDTO);
            return Ok("Employee Details Deleted");
        }
    }
}