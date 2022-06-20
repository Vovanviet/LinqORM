using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LinQTraining.config;

namespace LinQTraining.dao
{
    public class EmployeeDao
    {
        public List<Employee> getDataEmployee()
        {

            ConnectionSQLDATA connection = new ConnectionSQLDATA();
            SqlConnection sqlConnection = connection.GetSqlConnection();
            List<Employee> list = new List<Employee>();
            string query = "Select * from Employee";


            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee emp = new Employee();
                int employeeId = Convert.ToInt32(reader[0]);
                string employeeName = Convert.ToString(reader[1]);
                int projectId = Convert.ToInt32(reader[2]);
                emp.EmployeeId = employeeId;
                emp.EmployeeName = employeeName;
                emp.ProjectId = projectId;
                list.Add(emp);

            }
            sqlConnection.Close();
            return list;


        }




    }
}
