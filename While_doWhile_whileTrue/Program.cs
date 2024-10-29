using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_doWhile_whileTrue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while 
            int x = 0;
            while (x <= 5) 
            {
                Console.WriteLine("x = " + x);
                x ++;
            }
            Console.ReadKey();

            // Chương trình nhập n vào bàn phím n phải nằm trong khoảng từ 1 -> 99
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập vào số nguyên n từ 1 đến 99 : ");
            n = int.Parse(Console.ReadLine());
            //check đk
            while (n < 1 || n > 99)
            {
                Console.WriteLine("Nhập lại n, n chỉ được phép trong khoảng 1 đến 99: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Bạn đã nhập xong giá trị n, n = "+n);
            Console.ReadKey();

            // do while
            int a = 1;
            int tong = 0;
            do
            {  
                tong += a; // tong = tong + a
                a++; // a= a+1
            } while (a <= 5);
            Console.WriteLine("Tổng từ 1 đến 5 là :" + tong);
            Console.ReadKey();

            // while(true)
            int b = 0;
            while (true)
            {
                n++; //n=n+1
                Console.WriteLine("n= " + n);
                if (n == 10)
                    break;
            }
            Console.ReadLine();
        }
    }
}
