using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public static class PasswordService
    {
        public static bool VerifyPassword(string password, string salt, string hash)
        {
            Password passwordEmployee = new Password();
            return (passwordEmployee.Verify(password, salt, hash));
        }
    }
}
