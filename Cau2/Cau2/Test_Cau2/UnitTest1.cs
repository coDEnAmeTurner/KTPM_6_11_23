using Cau2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Test_Cau2
{
    [TestClass]
    public class UnitTestDeQuy
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
                    @"..\..\DataTest\TestPower.csv",
                    "TestPower#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestPower()
        {
            double a = double.Parse(TestContext.DataRow[0].ToString());
            int n = int.Parse(TestContext.DataRow[1].ToString());
            double expected = double.Parse(TestContext.DataRow[2].ToString());
            double actual = LuyThuaDeQuy.Power(a, n);
            Assert.AreEqual(expected, actual);
        }
    }
}
