using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQTraining.entity
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        public Project(int projectId, string projectName)
        {
            ProjectId = projectId;
            ProjectName = projectName;
        }

        public Project()
        {
        }
        public string ToString()
        {
            return "Project Id:" + ProjectId +
            "Project Name:" + ProjectName;
        }
    }
}
