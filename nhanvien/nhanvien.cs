using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staff
{
    internal class nhanvien
    {
        private string hoten; private int namsinh; private string diachi;
        private double luongcoban; private double heso;
        private double phucap; private double tongtien;

        public nhanvien()
        {
            this.hoten = "";
            this.namsinh = 0;
            this.diachi = " ";
            luongcoban = 0;
            heso = 0;
            phucap = 0;
            tongtien = 0;
        }
        public void nhap()
        {
            Console.WriteLine("nhap họ tên nv:");
            hoten = Console.ReadLine();
            Console.WriteLine("nhap năm sinh nv:");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap diachi nv:");
            diachi = Console.ReadLine();
            Console.WriteLine("nhap luongcoban nv:");
            luongcoban = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap heso lương:");
            heso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap phucap :");
            phucap = Convert.ToDouble(Console.ReadLine());
        }
        public static double tinhluong(nhanvien nv1)
        {
            double luong;
            luong = nv1.luongcoban * nv1.heso + nv1.phucap;
            return luong;
        }
        public void xuat()
        {
            Console.Write("in4 nhan vien:Họ tên:{0}, Năm sinh:{1}, Địa chỉ:{2}, Lương cơ bản:{3}, Hệ số:{4}, Phụ cấp:{5},",
            hoten, namsinh, diachi, luongcoban, heso, phucap);
    }


    }
}


