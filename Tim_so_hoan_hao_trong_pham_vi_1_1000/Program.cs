using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim_so_hoan_hao_trong_pham_vi_1_1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Số hoàn hảo là số có tổng các ước số bằng chính nó
            Console.OutputEncoding=Encoding.UTF8;
            Console.Write("Các số hoàn hảo trong phạm vi từ 1 đến 1000 là ");
            for (int i = 1; i <= 1000; i++)
            {
                int tong = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        tong += j;
                }
                if (tong == i)
                    Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
