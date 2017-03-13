using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManager.Entities
{
    public class BaseEntity
    {
        /// <summary>
        /// Errors of Trainne 
        /// </summary>
        public Dictionary<CategoryError, string> Errors = new Dictionary<CategoryError, string>();

        public enum CategoryError
        {
            DefaultError,
            ExcelFileError,
            TaksError
        }
    }
}
