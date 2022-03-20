using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaTran[,] mt1 ;
            
            MaTran[,] mt2 ;
            MaTran[,] mt3 ;
            while (mt1.m != mt2.m || mt1.n != mt2.n )
            {
                Console.WriteLine("2 ma tran k cung kich co,moi b nhap lai");
                break;
            }
            mt1.nhap();
            mt1.xuat();
            mt1.kiemtra();
            mt2.nhap();
            mt2.xuat();
            mt2.kiemtra();
            Console.WriteLine("Tong 2 ma tran:{0}", MaTran.Cong(mt1, mt2, mt3));
            Console.WriteLine("hieu 2 ma tran:{0}", MaTran.Hieu(mt1, mt2, mt3));
            Console.WriteLine("Tich 2 ma tran:{0}", MaTran.tich(mt1, mt2, mt3));
            Console.WriteLine("chuyen vi cua ma tran:{0}", MaTran.chuyenvi(mt1));



        }
    }
}
