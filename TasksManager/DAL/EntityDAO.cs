using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Entities;
using TasksManager.Helpers;
using TasksManager.Helpers.ExcelFile;

namespace TasksManager.DAL
{
    public class EntityExcelDAO<T> :IEtityDAO  where T:BaseEntity
    {
        /// <summary>
        /// List Of Entities
        /// </summary>
        protected static List<T> ListEntities = new List<T>();

        /// <summary>
        /// File Fulle Path
        /// </summary>
        public string FileFullPath { get;  set; }

     
        public EntityExcelDAO(string FileFullPath)
        {
            this.FileFullPath = FileFullPath;
            this.ReadData();
        }


        /// <summary>
        /// Read Data From Excel File
        /// </summary>
        protected void ReadData()
        {

            ExcelManager excelManager = new ExcelManager(this.FileFullPath);
            ListEntities.Clear();

            for (int index = 2; index <= excelManager.RowNumber(); index++)
            {
                // Create Entity Instance
                T taskProject = Activator.CreateInstance<T>();

                // Get Properties Info
                PropertyInfo[] ls_properties = taskProject.GetType().GetProperties();

                // Calculate Range
                string Colone1 = "A" + index.ToString();
                int NextCodeAssci = 'A' + ls_properties.Count() -1;
                if (NextCodeAssci > 'A' + 27) throw new NotImplementedException("Column Upter Z not yet implemented");
                string Colone2 = Convert.ToChar(NextCodeAssci) + index.ToString();

                // Read Values
                System.Array MyValues = (System.Array)excelManager.MySheet.get_Range(Colone1, Colone2).Cells.Value;

                // Create Objects
                int index_field = 1;
                foreach (PropertyInfo item in taskProject.GetType().GetProperties())
                {
                    if (MyValues.GetValue(1, index_field) != null)
                    {
                        object value = MyValues.GetValue(1, index_field);
                        try
                        {
                            item.SetValue(taskProject, value);
                        }
                        catch (Exception e)
                        {
                            string message = "Can not read the value " + value + "as " + item.DeclaringType.Name;

                            ShowMessage.AddMessage(message);
                        }
                        
                    }
                    index_field++;
                }

                ListEntities.Add(taskProject);
            }
        }

        /// <summary>
        /// Get Data
        /// </summary>
        /// <returns>List of Entities</returns>
        public virtual List<BaseEntity> GetData()
        {
            return ListEntities.ToList<BaseEntity>();
        }
    }
}
