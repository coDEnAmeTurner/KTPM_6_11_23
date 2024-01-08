using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cau6
{
    public struct Diem
    {
        public double toan;
        public double van;
        public double anh;

        public Diem(double t, double v, double a)
        {
            toan = t;
            van = v;
            anh = a;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Diem diem = (Diem)obj;
            return base.Equals(diem);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }

    public class HocVien
    {
        private static int dem = 0;

        private int maSo;
        private string hoTen;
        private string queQua; // thong tin ca nhan

        private Diem diem; // diem 3 mon

        public HocVien(string hoTen, string queQua, Diem diem)
        {
            this.MaSo = dem++;
            if (diem.toan >= 0 && diem.toan <= 10 && diem.van >= 0
                && diem.van <= 10 && diem.anh >= 0 && diem.anh <= 10 && hoTen != ""
                && hoTen != null && queQua != null && queQua != "")
            {
                this.HoTen = hoTen;
                this.QueQua = queQua;
                this.Diem = diem;
            }
            else
                throw new InvalidDataException();
        }

        public int MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string QueQua { get => queQua; set => queQua = value; }
        public Diem Diem { get => diem; set => diem = value; }

        public double tinhDiemTrungBinh() {
            return (diem.anh + diem.van + diem.toan) / 3;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            HocVien hv = (HocVien)obj;
            return base.Equals(hv) && diem.Equals(hv.diem);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }
}
