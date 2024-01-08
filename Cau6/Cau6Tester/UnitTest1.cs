using Cau6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Cau6Tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHocVienConstructorAllTrue()
        {
            HocVien hv = new HocVien("Vo Quoc Huy", "BMT", new Diem(9, 8, 9));
            Assert.AreEqual(new Diem(9, 8, 9), hv.Diem);
            Assert.AreEqual("Vo Quoc Huy", hv.HoTen);
            Assert.AreEqual("BMT", hv.QueQua);

        }

        [TestMethod]
        [DataRow(-1,1,1,"Huy","Vung Tau")]
        [DataRow(11,1,3,"Tam","Cat lai")]
        [DataRow(1,-2,4,"Gia","Nghe An")]
        [DataRow(0,12,6,"TIen","Thanh Hoa")]
        [DataRow(0,10,-5,"Thu","BMT")]
        [DataRow(0,9,15,"QHuy","BMT")]
        [DataRow(6,8,10,"","BMT")]
        [DataRow(6,8,10,null,"BMT")]
        [DataRow(6,8,10,"Vinny", "")]
        [DataRow(6,8,10,"Vinesauce", null)]
        [ExpectedException(typeof(InvalidDataException))]
        public void TestHocVienConstructorAllFalse(double toan, double anh, double van, string hoTen, string que)
        {
            HocVien hv = new HocVien(hoTen, que, new Diem(toan, van, anh));
        }

        
        [TestMethod]
        [DataRow(-2, 5, 9)]
        [DataRow(13, 5, 2)]
        [DataRow(1, -4, 10)]
        [DataRow(5, 19, 8)]
        [DataRow(1, 10, -5)]
        [DataRow(3, 9, 15)]
        [ExpectedException(typeof(InvalidDataException))]
        // Cac test case la FALSE
        public void TestTinhDiemTrungBinhFalse(double toan, double anh, double van)
        {
            HocVien hv = new HocVien("Huy", "BMT", new Diem(toan, van, anh));
            double diemavg = hv.tinhDiemTrungBinh();
        }

        [TestMethod]
        // Cac test case la TRUE
        public void TestDiemTrungBinhAllTrue()
        {
            HocVien hv = new HocVien("Huy", "Dak Lak", new Diem(10, 8, 9));
            Assert.AreEqual(9, hv.tinhDiemTrungBinh());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestQLHocVienConstructorNull()
        {
            List<HocVien> ds = null;
            QLHocVien quanly = new QLHocVien(ds);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQLHocVienConstructorKoPhanTu()
        {
            List<HocVien> ds = new List<HocVien>() { };
            QLHocVien quanly = new QLHocVien(ds);
        }

        [TestMethod]
        public void TestQLHocVienConstructorNotNull()
        {
            List<HocVien> actual = new List<HocVien>() { 
                new HocVien("Huy Vo", "Dak Lak", new Diem(1, 2, 3)) };
            Assert.AreEqual("Huy Vo", actual[0].HoTen);
            Assert.AreEqual("Dak Lak", actual[0].QueQua);
            Assert.AreEqual(new Diem(1, 2, 3), actual[0].Diem);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestTimDSHocVienCoHocBongNull()
        {
            List<HocVien> ds = null;
            QLHocVien quanly = new QLHocVien(ds);
            var dshocbong = quanly.timDSHocVienCoHocBong();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTimDSHocVienCoHocBongKoPhanTu() 
        {
            List<HocVien> ds = new List<HocVien>() { };
            QLHocVien quanly = new QLHocVien(ds);
            var dshocbong = quanly.timDSHocVienCoHocBong();
        }

        //kiểm thử test case danh sach có phần tử 
        [TestMethod]
        public void TestTimDSHocVienCoHocBongNotNull()
        {
            List<HocVien> actual = new List<HocVien>() { 
                new HocVien("Huy Vo", "Dak Lak", new Diem(4, 7, 3)),
                new HocVien("An Tien", "HCM", new Diem(1, 3, 4)),
                new HocVien("Anh Tuan", "Thanh Hoa", new Diem(10, 9, 10)),
            };
            var dshocbong = new QLHocVien(actual).timDSHocVienCoHocBong();
            Assert.AreEqual("Huy Vo"", dshocbong[0].HoTen);
            Assert.AreEqual("Dak Lak", dshocbong[0].QueQua);
            Assert.AreEqual(new Diem(8, 9, 10), dshocbong[0].Diem); 
            Assert.AreEqual("An Tien", dshocbong[1].HoTen);
            Assert.AreEqual("HCM", dshocbong[1].QueQua);
            Assert.AreEqual(new Diem(7, 10, 10), dshocbong[1].Diem);

        }
    }
}
