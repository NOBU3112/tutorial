using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangSoVaCacPhepToanCoBan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int DoSoi = 100;
            const int DoDong = 0;
            const double PI = 3.14;

            Console.WriteLine(" Do dong cua nuoc la " + DoDong);
            Console.WriteLine(" Do soi cua nuoc la {0}", DoSoi);
            Console.WriteLine($" PI = {PI}");
            // DoSoi = 200 loi
            Console.ReadKey();

            float x, y;
            Console.WriteLine("moi nhap vao x :");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("moi nhap vao y :");
            y = float.Parse(Console.ReadLine());
            float z1 = x + y;
            float z2 = x - y;
            float z3 = x * y;
            float z4 = x / y;
            float z5 = x % y;
            Console.WriteLine("{0} + {1} = {2}", x, y, z1);
            Console.WriteLine($"{x} - {y} = {z2}");
            Console.WriteLine(x + " * " + y + " = " + z3);
            Console.WriteLine("{0} / {1} = {2}", x, y, z4);
            Console.WriteLine("{0} % {1} = {2}", x, y, z5);
            Console.ReadKey();
        }
    }
}
