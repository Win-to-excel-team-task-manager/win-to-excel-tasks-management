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
    class TaskProjectBLO : EntityBLO<TaskProject>
    {
      
        public TaskProjectBLO()
        {
            
            string DirectoryPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string FileFullName = DirectoryPath + "/" + nameof(TaskProject);
            this.EntityDAO = new TaskProjectDAO(FileFullName);
        }
        public List<TaskProject> GetData()
        {
            return this.EntityDAO.GetData().Cast<TaskProject>().OrderBy(t => t.Order).ToList();
        }
    }
}
