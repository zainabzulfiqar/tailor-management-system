using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;

namespace TMS.DAL
{
    public class UserDAL
    {
        public List<Users> GetAllUsers()
        {
            Users u1 = new Users();
            u1.Name = "Admin";
            u1.Password = "admin";
            u1.Username = "admin";

            List<Users> users = new List<Users>();
            users.Add(u1);
            return users;
        }
    }
}
