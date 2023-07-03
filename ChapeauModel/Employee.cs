using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace ChapeauModel
{
    public class Employee
    {
        public int employeeId;
        public string name;
        public string hash;
        public string salt;
        public Role role;
    }
}
