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

        public List<Trainee> GetData()
        {
            return EntityDAO.GetData().Cast<Trainee>().ToList();
        }
    }
}
