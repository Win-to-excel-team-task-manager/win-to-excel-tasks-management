using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Entities;

namespace TasksManager.Entities
{
    public class Trainee : BaseEntity
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string ExcelDataPath { set; get; }
        public string FileName { get; internal set; }

        public override string ToString()
        {
            return this.FirstName + " " + LastName;

        }

    }
}
