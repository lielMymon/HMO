using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CoronaDetailsDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public Nullable<System.DateTime> Vaccination_1 { get; set; }
        public Nullable<System.DateTime> Vaccination_2 { get; set; }
        public Nullable<System.DateTime> Vaccination_3 { get; set; }
        public Nullable<System.DateTime> Vaccination_4 { get; set; }
        public string Manufacturer { get; set; }
        public Nullable<System.DateTime> Positive_result { get; set; }
        public Nullable<System.DateTime> Recovery_date { get; set; }
    }
}
