using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;

namespace TMS.BLL
{
    public class UserBLL
    {
        public List<Users> GetAllUsers()
        {
            return new TMS.DAL.UserDAL().GetAllUsers();
        } 
    }
}
