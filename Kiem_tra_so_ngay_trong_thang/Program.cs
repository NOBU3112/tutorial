using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiem_tra_so_ngay_trong_thang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;
            Console.WriteLine("Nhap vao thang bat ky");
            thang = int.Parse(Console.ReadLine());
            if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12 )
                Console.WriteLine("Thang {0} co 31 ngay", thang);
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11 )
                Console.WriteLine("Thang {0} co 30 ngay", thang);
            else if(thang == 2)
            {
                Console.WriteLine("Nhap vao nam: ");
                nam = int.Parse(Console.ReadLine());
                if ((nam % 4 == 0 && nam % 100 != 0)|| nam % 400 == 0)
                    Console.WriteLine("nam (0) ban vua nhap la nam nhuan, nen thang {1} co 29 ngay", nam,thang);
                else
                    Console.WriteLine("nam (0) ban vua nhap la nam khong nhuan, nen thang {1} co 28 ngay", nam, thang);
            }
            else
                Console.WriteLine("thang ban nhap khong ton tai");
            Console.ReadLine();
        }
    }
}
