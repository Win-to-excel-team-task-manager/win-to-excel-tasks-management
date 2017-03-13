using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Entities;

namespace TasksManager.DAL
{
    /// <summary>
    /// Trainee Task Manager
    /// </summary>
    public class TaskTraineeDAO : EntityExcelDAO<TaskTrainee>
    {
        public TaskTraineeDAO(string FileFullPath) : base(FileFullPath)
        {

        }




    }
}
