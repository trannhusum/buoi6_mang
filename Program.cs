 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace buoi6_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int choose,mang;
            Console.WriteLine("Nhap so phan tu (<=10)");
            mang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri");
            for (int i = 0; i < mang; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap vi tri muon chen");
            choose = int.Parse(Console.ReadLine());
            choose -= 1;
            for (int i= arr.Length-1; i>choose; i--) {
                arr[i] = arr[i-1];    
            }
            Console.WriteLine("Nhap gia tri muon chen");
            arr[choose] = int.Parse(Console.ReadLine());
            Console.WriteLine("Mang sau khi chen");
            for (int i = 0; i < mang+1; i++) {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();  
        }
    }
}
