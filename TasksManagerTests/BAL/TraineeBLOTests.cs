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
    public class TraineeBLOTests
    {
        [TestMethod()]
        public void TraineeBLOTest()
        {
            TraineeBLO TraineeBLO = new TraineeBLO();

        }

        [TestMethod()]
        public void GetDataTest()
        {
            TraineeBLO TraineeBLO = new TraineeBLO();
            TraineeBLO.GetData();

        }
    }
}