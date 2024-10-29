using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_tong_cac_so_le_tru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n, tong = 0;
            Console.WriteLine("Nhập vào n:");
            n=int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i += 2)
            {
                if(i==3)
                {
                    continue;
                }
                tong += i;
            }
            Console.WriteLine($"Tổng các số lẻ từ 0 đến {n} loại trừ giá trị 3 là {tong}");
            Console.ReadKey();
        }
    }
}
