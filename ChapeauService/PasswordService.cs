using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class PasswordService
    {
        public bool VerifyPassword(string password, string salt, string hash)
        {
            Password passwordEmployee = new Password();
            return (passwordEmployee.Verify(password, salt, hash));
        }
    }
}
