using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TasksManager.DAL;
using TasksManager.Entities;

namespace TasksManager.BAL
{
    /// <summary>
    /// Tainne Management
    /// </summary>
    public class TraineeBLO : EntityBLO<Trainee>
    {
        public TraineeBLO():base()
        {
            // [Role] The full path is the execution directory
            string FullFilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            FullFilePath += "/Stagiaires/";

            this.EntityDAO = new TraineeDAO(FullFilePath);
        }

        /// <summary>
        /// Get Trainee 
        /// Order By Number of Tasks and Minimum Number of Days
        /// </summary>
        /// <returns>List of Trainee</returns>
        public List<Trainee> GetData()
        {
            List<Trainee> list_trainee = EntityDAO.GetData().Cast<Trainee>().ToList();

            /// Read Tasks
            foreach (Trainee trainne in list_trainee)
            {
                TaskTraineeBLO taskTraineeBLO = new TaskTraineeBLO(trainne.FileName);
                trainne.NumberOfDaysJob = taskTraineeBLO.GetNumberOfDaysJob();
                trainne.NumberOfTask = taskTraineeBLO.GetNumberOfTask();
            }
            return list_trainee.OrderByDescending(t => t.NumberOfTask).ToList();
        }
    }
}
