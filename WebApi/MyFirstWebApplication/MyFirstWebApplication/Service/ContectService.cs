using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstWebApplication.Models;
using MyFirstWebApplication.DTO;

namespace MyFirstWebApplication.Service
{
    public class ContectService
    {
        public static List<Contect> contects = new List<Contect>()
       {
           new Contect(){ID=Guid.NewGuid(),Name="Bhavin",MobileNo=873380,Address="Ahmedabad"},
           new Contect(){ID=Guid.NewGuid(),Name="Inder",MobileNo=985622,Address="Jamnagar"}
       };

        public List<Contect> getContects()
        {
            return contects;
        }

        public List<Contect> ADD(ContectDTO dTO)
        {
            contects.Add(new Contect { ID = Guid.NewGuid(), Name = dTO.Name, MobileNo = dTO.MobileNo, Address = dTO.Address });
            return contects;
        }

        public Contect GetContectByID(ContectDTO dto)
        {
            Contect con = contects.Single(e => e.ID == dto.ID);
            return con;
        }
        public void DelContect(ContectDTO dto)
        {
            Contect details = contects.Single(e => e.ID == dto.ID);
            contects.Remove(details);
        }
    }
}