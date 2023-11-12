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
            if (dsHocVien != null)
                this.dsHocVien = dsHocVien;
            else
                throw new ArgumentNullException();
        }

        public List<HocVien> timDSHocVienCoHocBong()
        {
            return dsHocVien.FindAll(hocVien => hocVien.tinhDiemTrungBinh() >= 8.0 && hocVien.Diem.TOAN >= 5 
                                    && hocVien.Diem.VAN >= 5 && hocVien.Diem.ANH >= 5);
        }
    }
}
