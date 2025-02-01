using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign05
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly string storedUsername = "admin";
        private readonly string storedPassword = "password123";
        private readonly string storedRole = "Admin";
        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }
}
