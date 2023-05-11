using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Convert
{
    public class UserConvert
    {
        public static DTO.UserDTO Convert(DAL.User obj)
        {
            if (obj == null) return null;
            
            return new DTO.UserDTO()
            {
                Id = obj.Id,
                First_Name = obj.First_Name,
                Last_Name = obj.Last_Name,
                Address = obj.Address,
                Mobile_Phone = obj.Mobile_Phone,
                Phone = obj.Phone



            };
        }

        public static DAL.User Convert(DTO.UserDTO obj)
        {
            if (obj == null) return null;
            return new DAL.User()
            {
                Id = obj.Id,
                First_Name = obj.First_Name,
                Last_Name = obj.Last_Name,
                Address = obj.Address,
                Birth_Date = obj.Birth_Date,
                Mobile_Phone = obj.Mobile_Phone,
                Phone = obj.Phone



            };
        }

        public static List<DTO.UserDTO> Convert(List<DAL.User> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }

        public static List<DAL.User> Convert(List<DTO.UserDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
