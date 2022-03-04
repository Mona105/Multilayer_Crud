using System;
using CommanLayer.Models;
using DataLayer;
using System.Collections.Generic;

namespace BussinessAccessLayer
{
    public class BLEmployeeBussiness
    {
        private EmployeeDataAccess employeeData;
        public BLEmployeeBussiness()
        {
            employeeData = new EmployeeDataAccess();
        }
        public List<Employees> GetEmployees()
        {
            return employeeData.GetEmployees();
        }
    }
}
