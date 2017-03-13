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
    public class TaskProjectDAO : EntityExcelDAO<TaskProject>
    {
 
        public TaskProjectDAO(string FileFullPath) : base(FileFullPath)
        {

        }
        //public void WriteToExcel(TaskProject taskProject)
        //{
        //    ExcelManager excelManager = new ExcelManager("Tasks2.xlsx");
        //    //try
        //    //{
        //    excelManager.lastRow += 1;
        //    excelManager.MySheet.Cells[excelManager.lastRow, 1] = taskProject.Code;
        //    excelManager.MySheet.Cells[excelManager.lastRow, 2] = taskProject.Description;
        //    excelManager.MySheet.Cells[excelManager.lastRow, 3] = taskProject.NomberOfAffectation;

        //    ListEntities.Add(taskProject);
        //    excelManager.MyBook.Save();
        //    //}
        //    //catch (Exception ex)
        //    //{

        //    //}

        //}



        //public static List<Employee> FilterEmpList(string searchValue, string searchExpr)
        //{
        //    List<Employee> FilteredList = new List<Employee>();
        //    switch (searchValue.ToUpper())
        //    {
        //        case "NAME":
        //            FilteredList = EmpList.ToList().FindAll(emp => emp.Name.ToLower().Contains(searchExpr));
        //            break;
        //        case "MOBILE_NO":
        //            FilteredList = EmpList.ToList().FindAll(emp => emp.Number.ToLower().Contains(searchExpr));
        //            break;
        //        case "EMPLOYEE_ID":
        //            FilteredList = EmpList.ToList().FindAll(emp => emp.Employee_ID.ToLower().Contains(searchExpr));
        //            break;
        //        case "EMAIL_ID":
        //            FilteredList = EmpList.ToList().FindAll(emp => emp.Email_ID.ToLower().Contains(searchExpr));
        //            break;
        //        default:
        //            break;
        //    }
        //    return FilteredList;
        //}
    }
}
