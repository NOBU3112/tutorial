using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim_so_chia_het_cho_3_tu_10_den_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10; i<=50;i++)
            {
                if(i%3 == 0)
                {
                    Console.Write(i + " "); //viết trên 1 dòng
                }
            }
            Console.ReadKey();
        }
    }
}
