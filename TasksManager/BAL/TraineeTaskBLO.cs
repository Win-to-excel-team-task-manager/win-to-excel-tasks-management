using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.DAL;
using TasksManager.Entities;

namespace TasksManager.BAL
{
    public class TaskTraineeBLO : EntityBLO<TaskTrainee>
    {
        private string fileName;

        public TaskTraineeBLO(string fileName)
        {
            string DirectoryPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string FileFullPath = DirectoryPath + "/Stagiaires/" + fileName;


            this.EntityDAO = new TaskTraineeDAO(FileFullPath);
        }

        public List<TaskTrainee> GetData()
        {
            return this.EntityDAO.GetData().Cast<TaskTrainee>().ToList();
        }

        public object GetNumberOfDaysJob()
        {
            return this.EntityDAO.GetData().Cast<TaskTrainee>().Sum(t => t.NumberOfDays);
        }

        public object GetNumberOfTask()
        {
            return this.EntityDAO.GetData().Cast<TaskTrainee>().Where(t => t.NumberOfDays > 0).Count();
        }
    }
}
