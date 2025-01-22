using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastAssOOP.Part02
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string userName, string userPassword);
        public bool AuthorizeUser(Role r);

    }
}
