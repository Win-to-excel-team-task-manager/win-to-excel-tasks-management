using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Entities;

namespace TasksManager.DAL
{
    class TraineeDAO : IEtityDAO
    {
        /// <summary>
        /// List Of Entities
        /// </summary>
        protected static List<Trainee> ListEntities = new List<Trainee>();

        public string FileFullPath { set; get; }
       

        public TraineeDAO(string FullFilePath)
        {
            this.FileFullPath = FullFilePath;
            ReadData();
        }

        /// <summary>
        /// Load Trainee Data
        /// </summary>
        private void ReadData()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(this.FileFullPath);
            FileInfo[] ListExcelFile = directoryInfo.GetFiles("*.xlsx");

            ListEntities.Clear();
            foreach (FileInfo item in ListExcelFile)
            {
                Trainee trainee = new Trainee();
                trainee.FileName = item.Name;
                string Name = item.Name.Split('.')[0];
                string[] Names = Name.Split(' ');
                trainee.FirstName = Names[0];
                if (Names.Count() > 1)
                    trainee.LastName = Names[1];

                ListEntities.Add(trainee);
            }

        }

        public List<BaseEntity> GetData()
        {
            return ListEntities.Cast<BaseEntity>().ToList<BaseEntity>();
        }

       
    }
}
