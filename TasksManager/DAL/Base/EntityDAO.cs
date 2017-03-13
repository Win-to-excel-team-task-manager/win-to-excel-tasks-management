using FastExcel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Entities;
using TasksManager.Helpers;
using TasksManager.Helpers.ExcelFile;

namespace TasksManager.DAL
{
    public class EntityDAO<T> : IEtityDAO where T : BaseEntity
    {
        /// <summary>
        /// List Of Entities
        /// </summary>
        protected static List<T> ListEntities = new List<T>();

        /// <summary>
        /// File Fulle Path
        /// </summary>
        public string FileFullPath { get; set; }


        public EntityDAO(string FileFullPath)
        {
            this.FileFullPath = FileFullPath;
            this.ReadData();
        }


        /// <summary>
        /// Read Data From Excel File
        /// </summary>
        protected void ReadData()
        {
            
            FileInfo inputFile = new FileInfo(this.FileFullPath);

            // Test if File Exit
            if (!inputFile.Exists) throw new GwinFileNotExistException("The file " + this.FileFullPath + " not exist");


            using (FastExcel.FastExcel fastExcel = new FastExcel.FastExcel(inputFile, true))
            {
                Console.WriteLine("Reading data (Read Only Access) still needs enumerating...");
                Worksheet worksheet = fastExcel.Read(1, 1);

                // Cleat List of Entities
                ListEntities.Clear();

                // Read Rows
                worksheet.Read();
                Row[] rows = worksheet.Rows.ToArray();

                // Read PropertyInfo
                PropertyInfo[] Properties = typeof(T).GetProperties();


                // Create Entity for each Row
                for (int i = 1; i < rows.Count(); i++)
                {
                    Row row = rows[i];

                    // Read Values, 
                    object[] values = new object[Properties.Count()];
                    foreach (Cell cell in row.Cells)
                    {
                        // Excel Cell with empty Data Not exist in Cells
                        if (cell.ColumnNumber <= Properties.Count())
                            values[cell.ColumnNumber - 1] = cell.Value;
                    }

                    // Create Entity Instance
                    T Entity = Activator.CreateInstance<T>();

                    // Write Value in Entity

                    int index_column = 0;
                    foreach (PropertyInfo item in Properties)
                    {


                        object value = values[index_column];
                        try
                        {
                            if (value != null)
                            {
                                // Fix DateTime convert from Excel to C#
                                if (item.PropertyType == typeof(DateTime))
                                    value = FromExcelSerialDate(Convert.ToInt32(value));
                                item.SetValue(Entity, Convert.ChangeType(value, item.PropertyType));
                            }


                        }
                        catch (Exception e)
                        {
                            string message = "Can not read the value " + value + "as " + item.PropertyType;
                            Entity.Errors.Add(BaseEntity.CategoryError.ExcelFileError, message);
                        }


                        index_column++;
                    }

                    ListEntities.Add(Entity);
                }


            }






        }

        /// <summary>
        /// Concert Excel DateTime to C# DateTime
        /// </summary>
        /// <param name="SerialDate"></param>
        /// <returns></returns>
        public static DateTime FromExcelSerialDate(int SerialDate)
        {
            if (SerialDate > 59) SerialDate -= 1; //Excel/Lotus 2/29/1900 bug   
            return new DateTime(1899, 12, 31).AddDays(SerialDate);
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
