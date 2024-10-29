using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_tong_cac_so_chan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a,tong=0;
            Console.WriteLine("Nhập vào a");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) 
            {
                for (int i = 0; i<=a; i += 2)
                {
                    tong = tong + i;
                }
                Console.WriteLine($"Tổng các số chẵn từ 0 đến {a} là {tong} ");
            }
            else
                Console.WriteLine("tôi 0 tính số lẻ, bye bye");
            Console.ReadKey();
        }
    }
}
