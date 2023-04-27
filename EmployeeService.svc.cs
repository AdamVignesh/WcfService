using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Models;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
         employeesEntities1 entity = new employeesEntities1();
        public void AddEmployee(employee emp)
        {
            entity.employees.Add(emp);
            entity.SaveChanges();
        }
        public employee GetEmployees(int id)
        {
            List<employee> eList = new List<employee>();
            employee emp1 =  entity.employees.Find(id);

            return emp1;
        }
        public void updateEmployee(int empid,string updatedName)
        {
            employee values = entity.employees.FirstOrDefault(emp => emp.empno == empid);
            if(values!=null)
            {
                values.ename = updatedName;
            }
            entity.SaveChanges();                        
        }
        public void deleteEmployee(int empid)
        {
            employee value = entity.employees.FirstOrDefault(emp => emp.empno == empid);
            entity.employees.Remove(value);
            entity.SaveChanges();
        }
    }
}
