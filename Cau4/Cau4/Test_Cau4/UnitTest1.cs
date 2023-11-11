using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cau4;

namespace Test_Cau4
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
                    @"..\..\DataTest\TestConvert.csv", 
                    "TestConvert#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestConvert()
        {
            int x = int.Parse(TestContext.DataRow[0].ToString());
            int n = int.Parse(TestContext.DataRow[1].ToString());
            string expected = TestContext.DataRow[2].ToString();

            Radix test = new Radix(x);

            string actual = test.ConvertDecimalToAnother(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
