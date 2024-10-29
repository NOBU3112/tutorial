using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_n_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.OutputEncoding = Encoding.UTF8;
            int n, kq = 1;
            Console.WriteLine("Nhập vào n:");
            n = int.Parse(Console.ReadLine());
            //Dùng for
            for (int i=1; i<=n ; i++) 
            {
                Console.WriteLine("i = " + i);
                kq *= i;
            }
            Console.WriteLine("Kết quả giai thừa của {0} là: {1}", n, kq);

            //Dùng while
            int j = 1;
            kq = 1;
            while (j <= n)
            {
                Console.WriteLine("j = " + j);
                kq *= j;
                j++;
            }
            Console.WriteLine("Kết quả giai thừa của {0} là: {1}", n, kq);
            Console.ReadKey();
        }
    }
}
