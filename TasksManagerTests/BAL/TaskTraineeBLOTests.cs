using Microsoft.VisualStudio.TestTools.UnitTesting;
using TasksManager.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManager.BAL.Tests
{
    [TestClass()]
    public class TaskTraineeBLOTests
    {
        [TestMethod()]
        public void TaskTraineeBLOTest()
        {
            TraineeBLO TraineeBLO = new TraineeBLO();
            
            TaskTraineeBLO TaskTraineeBLO = new TaskTraineeBLO(TraineeBLO.GetData().First().FileName);
            
           
        }

        [TestMethod()]
        public void GetDataTest()
        {
            TraineeBLO TraineeBLO = new TraineeBLO();
            TaskTraineeBLO TaskTraineeBLO = new TaskTraineeBLO(TraineeBLO.GetData().First().FileName);
            TaskTraineeBLO.GetData();
        }
    }
}