using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLApp.DataModels;


namespace BLLApp.Contoller
{
   public class AccountBusinessController
    {
        public static  AspNetUser GetUserByUserName(string userName)
        {
            using (TestDatabaseEntities dbContext = new TestDatabaseEntities())
            {
                AspNetUser user = dbContext.AspNetUsers.FirstOrDefault(m => m.UserName == userName);
                return user;
            }
        }


        public static AspNetUser GetUserDetails(string userName,int userId)
        {
            using (TestDatabaseEntities dbContext = new TestDatabaseEntities())
            {
                AspNetUser user = dbContext.AspNetUsers.FirstOrDefault(m => m.UserName == userName && m.NumericUserId == userId);
                return user;
            }
        }
    }
}
