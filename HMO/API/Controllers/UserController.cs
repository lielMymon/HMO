using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class UserController : ApiController
    {

        BLL.UserService service=new BLL.UserService();

        [HttpGet]
        [Route("~/api/user/GetAllUsers")]
        public List<DTO.UserDTO> GetAllUsers()
        {
            return service.GetAllUsers();
        }

        [HttpGet]
        [Route("~/api/user/GetUserByTz")]
        public List<DTO.UserDTO> GetUserByTz(string UserId)
        {
            return service.GetUserByTz(UserId);
        }

        [HttpGet]
        [Route("~/api/user/GetUserByPhone")]
        public List<DTO.UserDTO> GetUserByPhone(string Phone)
        {
            return service.GetUserByPhone(Phone);
        }


        [HttpPost]
        [Route("~/api/user/AddUser")]
        public DTO.UserDTO AddUser(DTO.UserDTO User)
        {
            return service.AddUser(User);
        }

       
    }
}
