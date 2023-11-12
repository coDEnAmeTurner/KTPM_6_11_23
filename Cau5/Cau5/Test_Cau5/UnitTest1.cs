using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cau5;

namespace Test_Cau5
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\..\TestData\TestDienTich.csv", "TestDienTich#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestDienTich()
        {
            Diem p1 = new Diem(int.Parse(TestContext.DataRow[0].ToString()), int.Parse(TestContext.DataRow[1].ToString()));
            Diem p2 = new Diem(int.Parse(TestContext.DataRow[2].ToString()), int.Parse(TestContext.DataRow[3].ToString()));

            Rectangle rect = new Rectangle(p1, p2);

            int expected = int.Parse(TestContext.DataRow[4].ToString());

            int actual = rect.TinhDienTich();

            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"..\..\TestData\TestGiaoNhau.csv", "TestGiaoNhau#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestGiaoNhau()
        {
            Diem p1 = new Diem(int.Parse(TestContext.DataRow[0].ToString()), int.Parse(TestContext.DataRow[1].ToString()));
            Diem p2 = new Diem(int.Parse(TestContext.DataRow[2].ToString()), int.Parse(TestContext.DataRow[3].ToString()));
            Diem p3 = new Diem(int.Parse(TestContext.DataRow[4].ToString()), int.Parse(TestContext.DataRow[5].ToString()));
            Diem p4 = new Diem(int.Parse(TestContext.DataRow[6].ToString()), int.Parse(TestContext.DataRow[7].ToString()));

            Rectangle rect = new Rectangle(p1, p2);
            Rectangle rect2 = new Rectangle(p3, p4);

            bool expected = bool.Parse(TestContext.DataRow[8].ToString());

            bool actual = rect.KiemTraGiaoNhau(rect2);

            Assert.AreEqual(expected, actual);
        }
    }
}
