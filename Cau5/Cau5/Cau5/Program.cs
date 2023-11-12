using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau5
{
    public class Rectangle
    {
        public Diem top_Left { get; set; }
        public Diem bottom_Right { get; set; }

        public Rectangle(Diem p1, Diem p2)
        {
            top_Left = p1;
            bottom_Right = p2;
        }

        public int TinhDienTich()
        {
            int dai = Math.Abs(bottom_Right.X - top_Left.X);
            int rong = Math.Abs(bottom_Right.Y - top_Left.Y);
            return dai * rong;
        }

        public bool KiemTraGiaoNhau(Rectangle hcn)
        {
            bool traiPhai = top_Left.X <= hcn.bottom_Right.X && bottom_Right.X >= hcn.top_Left.X;
            bool trenDuoi = top_Left.Y >= hcn.bottom_Right.Y && bottom_Right.Y <= hcn.top_Left.Y;
            return traiPhai && trenDuoi;
        }

        public int getWidth()
        {
            return this.bottom_Right.X - this.top_Left.X;
        }

        public int getHeight()
        {
            return this.top_Left.Y - this.bottom_Right.Y;
        }

        static void Main(string[] args)
        {
            Diem p1 = new Diem(0, 5);
            Diem p2 = new Diem(3, 2);
            Diem p3 = new Diem(4, 5);
            Diem p4 = new Diem(7, 2);

            Rectangle r1 = new Rectangle(p1, p2);
            Rectangle r2 = new Rectangle(p3, p4);

            Console.WriteLine(r1.TinhDienTich());
            Console.WriteLine(r2.TinhDienTich());
            Console.WriteLine(r1.KiemTraGiaoNhau(r2));
            Console.ReadLine();
        }
    }
}