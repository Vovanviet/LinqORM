using LinQTraining.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQTraining.dao
{
    public class ProjectDao
    {
        public List<Project> getAllDataProject()
        {


            ConnectionSQLDATA connect = new ConnectionSQLDATA();
            SqlConnection connection = connect.GetSqlConnection();
            string query = "select * from Project";
            List<Project> list = new List<Project>();
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Project project = new Project();
                project.ProjectId = Convert.ToInt32(reader[0]);
                project.ProjectName = Convert.ToString(reader[1]);
                list.Add(project);
            }
            connection.Close();
            return list;
        }

    }
}
