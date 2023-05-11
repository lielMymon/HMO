using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {

       
        public string Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
       
        public string Address { get; set; }
        public System.DateTime Birth_Date { get; set; }
        public string Phone { get; set; }
        public string Mobile_Phone { get; set; }
    }
}
