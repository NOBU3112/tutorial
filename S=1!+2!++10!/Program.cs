using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_1__2___10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 1;
            int tong = 0;
            for (int i = 1; i <= 10; i++)
            {
                m = i * m;
                Console.WriteLine(m);
                //1 m = 1 = 1!
                //2 m = 2 = 2!
                //3 m = 6 = 6!
                tong = tong + m;
            }
            Console.WriteLine("Tong s= " + tong);
            Console.ReadKey();
        }
    }
}
