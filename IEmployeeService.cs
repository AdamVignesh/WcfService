using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Models;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        void AddEmployee(employee emp);
        [OperationContract]
        employee GetEmployees(int empno);

        [OperationContract]
        void updateEmployee(int id,string updatedName);
        
        [OperationContract]
        void deleteEmployee(int id);

    }

}
