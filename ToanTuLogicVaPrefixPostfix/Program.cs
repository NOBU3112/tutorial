using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanTuLogicVaPrefixPostfix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kq;
            int a = 6, b = 10;
            kq = !((a!=b) && (a<3));
            Console.WriteLine("Gia tri cua ket qua la: " + kq);
            Console.ReadKey();

            int x = 1, y = 2;
            int z = x++ - ++y + 1;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " +  z);
            Console.ReadKey();
        }
    }
}
