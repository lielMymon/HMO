using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace DAL.Model
{
    public class UserModel
    {

        public List<User> GetAllUsers()
        {
            using (HMOEntities db = new HMOEntities())
            {
                return db.Users.ToList();
            }
        }

        public List<User> GetUserByTz(string UserId)
        {

            using (HMOEntities db = new HMOEntities())
            {
                return db.Users.Where(x => x.Id == UserId).ToList();
            }
        }

        public List<User> GetUserByPhone(string Phone)
        {

            using (HMOEntities db = new HMOEntities())
            {
                return db.Users.Where(x => x.Phone == Phone).ToList();
            }
        }

      

        public User AddUser(User User)
        {
            using (HMOEntities db = new HMOEntities())
            {
                int x = 1, j = 0, result = 0;
                int[] arr = new int[18];
                if (User == null)
                    return null;

                if (User.First_Name.Length < 2 || User.Last_Name.Length < 2 || User.Id.Length < 9 || User.Id == null)
                    return null;

                for (int i = 0; i < User.Id.Length; i++)
                {

                    result = (User.Id[i] - '0') * x;
                    if (x == 1)
                        x = 2;
                    else x = 1;
                    arr[j++] = result;

                }

                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i] > 9)
                        arr[i] = arr[i] / 10 + arr[i] % 10;
                }
                result = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    result += arr[i];

                }
                if (result % 10 != 0)
                    return null;

                User = db.Users.Add(User);
                db.SaveChanges();
                return User;

            }
        }
    }
}
