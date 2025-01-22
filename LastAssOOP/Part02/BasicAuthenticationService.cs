using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastAssOOP.Part02
{
    enum Role
    {
        Admin,
        Guest
    }
    internal class BasicAuthenticationService : IAuthenticationService
    {
      
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public Role Role { get; set; }

        private string AuthUserName;
        private string AuthUserPass;

        public BasicAuthenticationService(string userName , string userPassword, Role role)
        {
            UserName = userName;
            UserPassword = userPassword;
            Role = role;
        }
        public bool AuthenticateUser(string userName,string userPassword)
        {
           
            AuthUserName = userName;
            AuthUserPass = userPassword;
            return UserName == userName && UserPassword == userPassword;


        }

        public bool AuthorizeUser(Role r)
        {
            if (AuthenticateUser(AuthUserName, AuthUserName) )
            {
                if (r == Role) return true;
                else  return false; 
            }
            return false;
        }
    }
}
