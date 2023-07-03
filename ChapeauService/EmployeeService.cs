using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauService
{
    public class EmployeeService
    {
        private EmployeeDao employeeDao;

        public EmployeeService()
        {
            employeeDao = new EmployeeDao();
        }
        public Employee GetById(int id) 
        {
            return employeeDao.GetById(id);
        }
        public Employee GetByUsername(string username)
        {
            return employeeDao.GetByUsername(username);
        }
    }
}
