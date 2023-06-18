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

        public void AddEmployee(string name, string password)
        {

        }

        public void EditEmployee() 
        {

        }

        public void DeleteEmployee()
        {

        }
        public bool CheckUserID(string input)
        {
            List<char> charList = new List<char>();
            for(int i = 0; i <= 9; i++)
            {
                charList.Add(Convert.ToChar(i.ToString()));
            }
            foreach (char c in input)
            {
                if (!charList.Contains(c))
                    return false;      
            }
            return true;
        }
    }
}
