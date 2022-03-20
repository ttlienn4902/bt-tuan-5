using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class DanhSach
    {
        private int n; //Số lượng sinh viên
        private svien[] DS; //Mảng chứa danh sách Sinh viên

        public void nhapn()
        {
            DS = new svien[n];
           
        }
        public void nhapds()
        {
           
            for (int i = 0; i < n;i++)
            { 
                Console.WriteLine("Nhập in4 sinh viên {0} :", i + 1);
                DS[i].nhap();
            }    
                
        }
        public void xuatds()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("in4 sinh viên {0} :", i + 1);
                DS[i].xuat();
            }
        }
        public void sxep()
        {
            Array.Sort(DS);
            foreach (svien i in DS)
            {
                Console.WriteLine(i);
            }    
        }
    
        }
    }

