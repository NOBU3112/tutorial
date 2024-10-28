using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phuong_trinh_bac_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, delta;
            Console.WriteLine("Nhap vao gia tri cua a:");
            a= float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao gia tri cua b:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao gia tri cua c:");
            c = float.Parse(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
            if (a == 0)
            {
                float x = -c / b;
                Console.WriteLine("Phuong trinh co nghiem la" + x);
            }
            else
            {
                if (delta < 0)
                    Console.WriteLine("Chuong trinh vo nghiem");
                else if (delta == 0)
                {
                    float x = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep la {0}", x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
            Console.Read();
        }
    }
}
