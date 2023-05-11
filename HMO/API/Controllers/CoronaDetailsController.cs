using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class CoronaDetailsController : ApiController
    {

        BLL.CoronaDetailsService service = new BLL.CoronaDetailsService();

        [HttpGet]
        [Route("~/api/coronaDetails/GetAll")]
        public List<DTO.CoronaDetailsDTO> GetAll()
        {
            return service.GetAll();
        }

        
        public List<DTO.CoronaDetailsDTO> GetDetailsByTz(string Tz)
        {
            return service.GetDetailsByTz(Tz);
        }

        [HttpGet]
        [Route("~/api/coronaDetails/GetDetailsById")]
        public List<DTO.CoronaDetailsDTO> GetDetailsById(int Id)
        {
            return service.GetDetailsById(Id);
        }

        [HttpGet]
        [Route("~/api/coronaDetails/GetAllPositives")]
        public List<DTO.CoronaDetailsDTO> GetAllPositives()
        {
            return service.GetAllPositives();
        }


        [HttpPost]
        [Route("~/api/coronaDetails/Add")]
        public DTO.CoronaDetailsDTO Add(DTO.CoronaDetailsDTO x)
        {
            return service.Add(x);
        }

        [HttpGet]
        [Route("~/api/coronaDetails/UnvaccinatedNum")]
        public int UnvaccinatedNum()
        {
            
            return  service.UnvaccinatedNum();
        }

        [HttpGet]
        [Route("~/api/coronaDetails/Monthlypatients")]

        public Dictionary<int, int> Monthlypatients()
        {
            return service.Monthlypatients();
        }
    }
}
