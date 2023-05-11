using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService
    {
        DAL.Model.UserModel model=new DAL.Model.UserModel();

        public List<DTO.UserDTO> GetAllUsers()
        {
            return Convert.UserConvert.Convert(model.GetAllUsers());
        }


        public List<DTO.UserDTO> GetUserByTz(string UserId)
        {
            return Convert.UserConvert.Convert(model.GetUserByTz(UserId));
        }
        public List<DTO.UserDTO> GetUserByPhone(string Phone)
        {
            return Convert.UserConvert.Convert(model.GetUserByPhone(Phone));
        }

        public DTO.UserDTO AddUser(DTO.UserDTO User)
        {
            return Convert.UserConvert.Convert(model.AddUser(Convert.UserConvert.Convert(User)));
        }
    }
}
