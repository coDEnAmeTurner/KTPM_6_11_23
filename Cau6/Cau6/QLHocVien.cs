using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau6
{
    public class QLHocVien
    {
        private List<HocVien> dsHocVien = new List<HocVien>();

        public QLHocVien(List<HocVien> dsHocVien)
        {
            if (dsHocVien != null && dsHocVien.Count != 0)
                this.dsHocVien = dsHocVien;
            else if (dsHocVien == null)
                throw new ArgumentNullException();
            else
                throw new ArgumentException();
        }

        public List<HocVien> timDSHocVienCoHocBong()
        {
            if (dsHocVien != null && dsHocVien.Count != 0)
                return dsHocVien.FindAll(hocVien => hocVien.tinhDiemTrungBinh() >= 8.0 && hocVien.Diem.TOAN >= 5 
                                    && hocVien.Diem.VAN >= 5 && hocVien.Diem.ANH >= 5);
            else if (dsHocVien == null)
                throw new ArgumentNullException();
            else
                throw new ArgumentException();
        }
    }
}
