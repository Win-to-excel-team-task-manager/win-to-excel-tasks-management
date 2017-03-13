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
    public class TaskProjectBLOTests
    {
        [TestMethod()]
        public void TaskProjectBLOTest()
        {
            TaskProjectBLO TaskProjectBLO = new TaskProjectBLO();
        }

        [TestMethod()]
        public void GetDataTest()
        {
            TaskProjectBLO TaskProjectBLO = new TaskProjectBLO();
            TaskProjectBLO.GetData();
        }
    }
}