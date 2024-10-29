using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiem_tra_so_nguyen_to
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            Console.WriteLine("Nhập số nguyên a>0 : ");
            a = int.Parse(Console.ReadLine());
            //check a có lớn hơn 0
            while (a < 0)
            {
                Console.WriteLine("Nhập lại a, a phải lớn hơn 0:");
                a = int.Parse(Console.ReadLine());
            }
            //Kiểm tra nguyên số
            int demUoc = 0;
            for (int i = 1;  i <= a; i++)
            {
                if(a % i == 0)
                {
                    demUoc ++;
                }
            }
            if (demUoc == 2)
                Console.WriteLine("{0} là số nguyên tố", a);
            else
                Console.WriteLine("{0} không phải là số nguyên tố", a);
            Console.ReadLine();
        }
    }
}
