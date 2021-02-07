using RegisterAndLoginApp_2b_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterAndLoginApp_2b_2.Services
{
    public class SecurityService
    {
                
        UsersDAO usersDAO = new UsersDAO();      

        public bool IsValid(UserModel user)
        {
            return usersDAO.FindUserByNameAndPassword(user);           
        }
    }
}
