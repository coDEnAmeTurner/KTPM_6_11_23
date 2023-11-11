using Cau3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_Cau3
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
                    @"..\..\DataTest\TestCal.csv",
                    "TestCal#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestCal()
        {
            int x = int.Parse(TestContext.DataRow[0].ToString());
            int expected = int.Parse(TestContext.DataRow[1].ToString());
            int n = int.Parse(TestContext.DataRow[2].ToString());
            string arr = TestContext.DataRow[3].ToString();
            
            List<int> list = Array.ConvertAll(arr.Split(';'), int.Parse).ToList();
            list.Reverse(); // xy ly chuoi arr input thanh cac co so 

            Polynomial pl = new Polynomial(n, list);
            int actual = pl.Cal(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
