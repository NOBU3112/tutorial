using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cho_biet_thang_thuoc_quy_may
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int thang;
            Console.WriteLine("nhâp vào 1 tháng bất kỳ: ");
            thang = int.Parse(Console.ReadLine());
            if (thang == 1 || thang == 2 || thang == 3)
                Console.WriteLine("tháng {0} thuộc quý 1", thang);
            else if (thang == 4 || thang == 5 || thang == 6)
                Console.WriteLine("tháng {0} thuộc quý 2", thang);
            else if (thang == 7 || thang == 8 || thang == 9)
                Console.WriteLine("tháng {0} thuộc quý 3", thang);
            else if (thang == 10 || thang == 11 || thang == 12)
                Console.WriteLine("tháng {0} thuộc quý 4", thang);
            else
                Console.WriteLine("tháng nhập vào không hợp lệ");
            Console.ReadKey();
        }
    }
}
