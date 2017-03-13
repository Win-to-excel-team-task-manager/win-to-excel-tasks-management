using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Entities;
using TasksManager.Helpers.ExcelFile;

namespace TasksManager.DAL
{
    public class TaskProjectDAO : EntityDAO<TaskProject>
    {
 
        public TaskProjectDAO(string FileFullPath) : base(FileFullPath)
        {

        }
    }
}
