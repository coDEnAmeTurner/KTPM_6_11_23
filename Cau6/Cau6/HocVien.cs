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
        public double TOAN;
        public double VAN;
        public double ANH;

        public Diem(double tOAN, double vAN, double aNH)
        {
            TOAN = tOAN;
            VAN = vAN;
            ANH = aNH;
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
        private string queQua;
        private Diem diem;

        public HocVien(string hoTen, string queQua, Diem diem)
        {
            this.MaSo = dem++;
            this.HoTen = hoTen;
            this.QueQua = queQua;
            if (diem.TOAN >= 0 && diem.TOAN <= 10 && diem.VAN >= 0
                && diem.VAN <= 10 && diem.ANH >= 0 && diem.ANH <= 10 && hoTen != ""
                && hoTen != null && queQua != null && queQua != "")
            {
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
            return (diem.ANH + diem.VAN + diem.TOAN) / 3;
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
