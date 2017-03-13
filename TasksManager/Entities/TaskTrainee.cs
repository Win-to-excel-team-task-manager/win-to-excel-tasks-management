using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManager.Entities
{
    public class TaskTrainee : BaseEntity
    {
        public string Title { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public DateTime NumberOfDays { set; get; }
    }
}
