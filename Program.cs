using System;

namespace Baitapvidu
{
     class Program
    {
        static void NhapDay(int n, int[] A)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap A[{i}]= ");
                A[i] = int.Parse(Console.ReadLine());
            }
        }
        static int TongDuong(int n,int[] A)
        {
            int tong = 0;
            for(int i= 0;i < n;i++)
            {
                if (A[i] > 0)
                {
                    tong+=A[i];
                }                   
            }
            return tong;
        }
    static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap n phan tu cua day so: ");
                n = int.Parse(Console.ReadLine());
            } while (2 >= n || n >= 20);
            int[] A = new int[n];
            NhapDay(n,A);
            int kq = TongDuong(n,A);
            Console.Write($"Tong cac so nguyen duong trong day = {kq}");
            Console.ReadKey();
        }
    }
}
