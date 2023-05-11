using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace DAL.Model
{
    public class CoronaDetailsModel
    {
        
        public List<CoronaDetail> GetAll()
        {
            using (HMOEntities db = new HMOEntities())
            {
                return db.CoronaDetails.ToList();
            }
        }

       
        public List<CoronaDetail> GetAllPositives()
        {

            using (HMOEntities db = new HMOEntities())
            {
                return db.CoronaDetails.Where(x => x.Recovery_date >DateTime.Now).ToList();
            }
        }

        public List<CoronaDetail> GetDetailsByTz(string Tz)
        {

            using (HMOEntities db = new HMOEntities())
            {
                return db.CoronaDetails.Where(x => x.UserId == Tz).ToList();
            }
        }

        public List<CoronaDetail> GetDetailsById(int Id)
        {

            using (HMOEntities db = new HMOEntities())
            {
                return db.CoronaDetails.Where(x => x.Id == Id).ToList();
            }
        }



        public int UnvaccinatedNum()
        {
            using (HMOEntities db = new HMOEntities())
            {
                int count = 0;
                foreach (var item in db.CoronaDetails)
                {
                    if (item.Vaccination_1 == null && item.Vaccination_2 == null && item.Vaccination_3 == null && item.Vaccination_3 == null
                         && item.Vaccination_4 == null )
                        count++;
                }

                return count;

            }
        }

        public CoronaDetail Add(CoronaDetail x)
        {
            using (HMOEntities db = new HMOEntities())
            {
                if (x == null)
                    return null;
                if (x.Positive_result > DateTime.Now)
                    return null;
                x = db.CoronaDetails.Add(x);
                db.SaveChanges();
                return x;

            }
        }

        public Dictionary<int, int> Monthlypatients()
        {
            using (HMOEntities db = new HMOEntities())
            {
                Dictionary<int, int> x = new Dictionary<int, int>();
                int count = 0,daysAmount=DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month);
                for (int i = 1; i<= daysAmount; i++)
                {
                    foreach (CoronaDetail item in db.CoronaDetails)
                    {
                        if (item.Positive_result!=null &&item.Positive_result.Value.Month == DateTime.Now.Month && item.Positive_result.Value.Day == i)
                        {
                            count++;
                        }
                        
                    }
                    x.Add(i, count);
                    count = 0;
                }

                return x;
            }
        }




    }
}
