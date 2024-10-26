using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanTuGanCacPhepSoSanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            x = 5;
            y = 4;
            Console.WriteLine("x=" + x);
            x +=y; // x= x+y
            Console.WriteLine("x="+ x);
            Console.ReadKey();

            int n;
            Console.WriteLine("Moi nhap vao so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ban vua nhap vao so {n}");
            if (n % 2 == 0)
                Console.WriteLine("so {0} la so chan",n);
            else
                Console.WriteLine("so {0} la so le", n);
            Console.ReadKey();

        }
    }
}
