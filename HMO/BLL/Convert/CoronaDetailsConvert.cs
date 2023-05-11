        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Convert
{
    public class CoronaDetailsConvert

    {

        public static DTO.CoronaDetailsDTO Convert(DAL.CoronaDetail obj)
        {
            if (obj == null) return null;
            return new DTO.CoronaDetailsDTO()
            {
                Id = obj.Id,
                UserId=obj.UserId,
                Vaccination_1=obj.Vaccination_1,
                Vaccination_2=obj.Vaccination_2,
                Vaccination_3=obj.Vaccination_3,
                Vaccination_4=obj.Vaccination_4,
                Manufacturer=obj.Manufacturer,
                Positive_result= obj.Positive_result,
                Recovery_date=obj.Recovery_date


            };


        }

        public static DAL.CoronaDetail Convert(DTO.CoronaDetailsDTO obj)
        {
            if (obj == null) return null;
            return new DAL.CoronaDetail()
            {
                Id = obj.Id,
                UserId = obj.UserId,
                Vaccination_1 = obj.Vaccination_1,
                Vaccination_2 = obj.Vaccination_2,
                Vaccination_3 = obj.Vaccination_3,
                Vaccination_4 = obj.Vaccination_4,
                Manufacturer = obj.Manufacturer,
                Positive_result = obj.Positive_result,
                Recovery_date = obj.Recovery_date


            };


        }

        public static List<DTO.CoronaDetailsDTO> Convert(List<DAL.CoronaDetail> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }

        public static List<DAL.CoronaDetail> Convert(List<DTO.CoronaDetailsDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
