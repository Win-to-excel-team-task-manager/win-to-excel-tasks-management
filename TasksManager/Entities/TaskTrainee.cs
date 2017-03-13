using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManager.Entities
{
    public class TaskTrainee : BaseEntity
    {

        public string ModelingStage { set; get; }
        public string Project { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }

        public DateTime StartDate { set; get; }


        
        private DateTime endDate;
        public DateTime EndDate
        {
            set
            {
                this.endDate = value;
                CalculateNumberOfDays();
            }
            get
            {
                return this.endDate;
            }
        }
        public int NumberOfDays { set; get; }

        /// <summary>
        /// Calculate Number of Days
        /// </summary>
        private void CalculateNumberOfDays()
        {
            TimeSpan timeSpan = this.EndDate -this.StartDate ;
            this.NumberOfDays = timeSpan.Days;
            if (this.EndDate == this.StartDate)
                this.NumberOfDays = 1;
            if (this.NumberOfDays < 0)
                this.Errors.Add(CategoryError.TaksError, "Number of Days must not be negative ");
        }

        public string ErrorsMessage()
        {
            string Message = "";
            foreach (var item in this.Errors)
            {
                Message += item.Value + "\n";
            }
            return Message;
        }
    }
}
