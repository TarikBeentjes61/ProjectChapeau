using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauService
{
    public class EmployeeService
    {
        public EmployeeDao employeeDao;

        public EmployeeService()
        {
            employeeDao= new EmployeeDao();
        }
        public List<Employee> GetAll()
        {
            return employeeDao.GetAll();
        }
        public Employee GetById(int id) 
        {
            return employeeDao.GetById(id);
        }
    }
}
