using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiem_tra_nam_nhuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int nam;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời nhập vào 1 năm bất kỳ: ");
            nam = int.Parse(Console.ReadLine());
            if((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                Console.WriteLine("{0} là năm nhuận", nam);
            else
                Console.WriteLine("{0} không phải là năm nhuận", nam);
            Console.ReadKey(); //
        }
    }
}
