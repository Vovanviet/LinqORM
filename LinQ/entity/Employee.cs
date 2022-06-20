using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQTraining.entity
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int ProjectId { get; set; }

        public Employee() { }

        public Employee(int employeeId, string employeeName, int projectId)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            ProjectId = projectId;
        }
        public override string ToString()
        {
            return "Employee ID:" + EmployeeId + "\nEmployee Name:" + EmployeeName + "\nProject ID:" + ProjectId;
        }
    }
}
