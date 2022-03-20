using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtran
{
    internal class MaTran
    {
        private int m; //Số dòng
        private int n; //Số cột
        private int[,] a; //Mảng 2 chiều
        public MaTran(int m, int n)
        {
            this.m = m; this.n = n;
        }
        
        public void nhap()
        { Console.WriteLine("NHAP SO DONG:");

            this.m =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NHAP SO COT:");
            this.n = Convert.ToInt32(Console.ReadLine());
            int[,] a=new int[m,n];

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine("nhap phan tu [{0},{1}]",i+1,j+1);
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                }    
            }    
        }
        public void XUAT()
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("ma tran co dang", a[i, j]);
                     
                }
            }
          

        }
        public static int Cong(MaTran a,MaTran b,MaTran c)
        {
            
            for( int i = 0; i <a.n;i++ )
            {
                for( int j = 0; j < a.m;j++ )
                {
                    for(int l=0; l<b.n;l++ )
                    {
                        for(int k=0; k < b.m; k++) 
                        {
                            

                        } 
                            
                    }    
                    
                }    
            }    
        }
        public static int chuyenvi(MaTran a)
        {
            int[,] a1;
            for( int i = 0; i < a.m;i++ )
            {
                for(int j=0; i < a.n;j++) 
                {
                    if (a1[i,j]==a[j,i])
                        return a1;
                } 
                    
            }    
        }
        public void kiemtra()
        {
            MaTran[,] a;
            if (a.m == a.n) Console.WriteLine("day la ma tran vuong");
            else Console.WriteLine("DAY KP ma tran vuong");
        }
    }
}
