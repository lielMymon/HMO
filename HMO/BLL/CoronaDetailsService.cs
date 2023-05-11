using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CoronaDetailsService
    {

        DAL.Model.CoronaDetailsModel model = new DAL.Model.CoronaDetailsModel();

        public List<DTO.CoronaDetailsDTO> GetAll()
        {
            return Convert.CoronaDetailsConvert.Convert(model.GetAll());
        }

        public List<DTO.CoronaDetailsDTO> GetDetailsByTz(string Tz)
        {
            return Convert.CoronaDetailsConvert.Convert(model.GetDetailsByTz(Tz));
        }
        public List<DTO.CoronaDetailsDTO> GetDetailsById(int Id)
        {
            return Convert.CoronaDetailsConvert.Convert(model.GetDetailsById(Id));

        }

        public List<DTO.CoronaDetailsDTO> GetAllPositives()
        {
            return Convert.CoronaDetailsConvert.Convert(model.GetAllPositives());
        }


        public int UnvaccinatedNum()
        {
            return model.UnvaccinatedNum();
        }

       


        public DTO.CoronaDetailsDTO Add(DTO.CoronaDetailsDTO x)
        {
            return Convert.CoronaDetailsConvert.Convert(model.Add(Convert.CoronaDetailsConvert.Convert(x)));
        }

        public Dictionary<int, int> Monthlypatients()
        {
            return model.Monthlypatients();
        }
    }
}
