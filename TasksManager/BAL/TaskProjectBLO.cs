using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.DAL;
using TasksManager.Entities;

namespace TasksManager.BAL
{
    /// <summary>
    /// Task Project Management
    /// </summary>
    public class TaskProjectBLO : EntityBLO<TaskProject>
    {
      
        public TaskProjectBLO()
        {
            string DirectoryPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string FullFilePath = Path.Combine(DirectoryPath, nameof(TaskProject) + ".xlsx");
            this.EntityDAO = new TaskProjectDAO(FullFilePath);
        }
        public List<TaskProject> GetData()
        {
            return this.EntityDAO.GetData().Cast<TaskProject>().OrderBy(t => t.Order).ToList();
        }
    }
}
