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
        //kiem thu hoc vien constructor
        [TestMethod]
        public void TestHocVienConstructorAllTrue()
        {
            HocVien hv = new HocVien("Tran Luu Quoc Tuan", "Binh Duong", new Diem(10, 8, 9));
            Assert.AreEqual(new Diem(10, 8, 9), hv.Diem);
            Assert.AreEqual("Tran Luu Quoc Tuan", hv.HoTen);
            Assert.AreEqual("Binh Duong", hv.QueQua);

        }

        [TestMethod]
        [DataRow(-1,1,1,"Tuan","Binh Duong")]
        [DataRow(11,1,3,"Tu","HCM")]
        [DataRow(1,-2,4,"ATuan","HCM")]
        [DataRow(0,12,6,"MTam","HCM")]
        [DataRow(0,10,-5,"Dat","BMT")]
        [DataRow(0,9,15,"QHuy","BMT")]
        [DataRow(7,9,10,"","BMT")]
        [DataRow(7,9,10,null,"BMT")]
        [DataRow(7,9,10,"Vinny", "")]
        [DataRow(7,9,10,"Vinesauce", null)]
        [ExpectedException(typeof(InvalidDataException))]
        public void TestHocVienConstructorAllFalse(double toan, double anh, 
                                            double van, string hoTen, string que)
        {
            HocVien hv = new HocVien(hoTen, que, new Diem(toan, van, anh));

        }

        //kiem thu HocVien.tinhDiemTrungBinh()
        [TestMethod]
        [DataRow(-1, 1, 1)]
        [DataRow(11, 1, 3)]
        [DataRow(1, -2, 4)]
        [DataRow(0, 12, 6)]
        [DataRow(0, 10, -5)]
        [DataRow(0, 9, 15)]
        [ExpectedException(typeof(InvalidDataException))]
        //kiểm thử các test case false
        public void TestTinhDiemTrungBinhFalse(double toan, double anh, double van)
        {
            HocVien hv = new HocVien("Tuan", "BD", new Diem(toan, van, anh));
            double diemavg = hv.tinhDiemTrungBinh();
        }

        [TestMethod]
        //kiểm thử các test case true
        public void TestDiemTrungBinhAllTrue()
        {
            HocVien hv = new HocVien("Tran Luu Quoc Tuan", "Binh Duong", new Diem(10, 8, 9));
            Assert.AreEqual(9, hv.tinhDiemTrungBinh());
        }

        //kiem thu QLHocVien Constructor
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        //kiểm thử test case danh sach là null
        public void TestQLHocVienConstructorNull()
        {
            List<HocVien> ds = null;
            QLHocVien quanly = new QLHocVien(ds);
        }

        //kiểm thử test case danh sach không phần tử 
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQLHocVienConstructorKoPhanTu()
        {
            List<HocVien> ds = new List<HocVien>() { };
            QLHocVien quanly = new QLHocVien(ds);
        }

        [TestMethod]
        //kiểm thử test case danh sách ko null, có phần tử
        public void TestQLHocVienConstructorNotNull()
        {
            List<HocVien> actual = new List<HocVien>() { 
                new HocVien("Tran Luu", "Di An", new Diem(1, 2, 3)) };
            Assert.AreEqual("Tran Luu", actual[0].HoTen);
            Assert.AreEqual("Di An", actual[0].QueQua);
            Assert.AreEqual(new Diem(1, 2, 3), actual[0].Diem);
        }

        //kiem thu timDSHocVienCoHocBong()
        [TestMethod]
        //kiểm thử test case danh sach là null
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestTimDSHocVienCoHocBongNull()
        {
            List<HocVien> ds = null;
            QLHocVien quanly = new QLHocVien(ds);
            var dshocbong = quanly.timDSHocVienCoHocBong();
        }

        //kiểm thử test case danh sach không phần tử 
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
                new HocVien("Tran Luu", "Di An", new Diem(1, 2, 3)),
                new HocVien("Quoc Tuan", "Binh Duong", new Diem(8, 9, 10)),
                new HocVien("Anh Tuan", "HCM", new Diem(7, 10, 10)),
            };
            var dshocbong = new QLHocVien(actual).timDSHocVienCoHocBong();
            Assert.AreEqual("Quoc Tuan", dshocbong[0].HoTen);
            Assert.AreEqual("Binh Duong", dshocbong[0].QueQua);
            Assert.AreEqual(new Diem(8, 9, 10), dshocbong[0].Diem); 
            Assert.AreEqual("Anh Tuan", dshocbong[1].HoTen);
            Assert.AreEqual("HCM", dshocbong[1].QueQua);
            Assert.AreEqual(new Diem(7, 10, 10), dshocbong[1].Diem);

        }
    }
}
