using System.Collections;
using System.Linq;
using LinQTraining;

namespace LinQStraining
{
    public class program
    {

        public static void Main(string[] args)
        {
           EmployeeDao employeeDao = new EmployeeDao();
            ProjectDao projectDao = new ProjectDao();
            List<Project> list = projectDao.getAllDataProject();
            List<Employee> empList = employeeDao.getDataEmployee();

            /* foreach (Project project in list)
             {
                 Console.WriteLine(project.ToString());
             }
             foreach (var lists in empList)
             {
                 Console.WriteLine(lists.ToString());
             }*/
            var Linq1 = empList.Join(list,emp=>emp.ProjectId,pro=>pro.ProjectId,
                    (emp,pro)=>new {emp.EmployeeName,pro.ProjectName});
            foreach(var data in Linq1)
            {
                Console.WriteLine("\nEmployee Name:" + data.EmployeeName + " \nProject Name:" + data.ProjectName);
            }
        }
    }

}