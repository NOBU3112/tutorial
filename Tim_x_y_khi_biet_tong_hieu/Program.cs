using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim_x_y_khi_biet_tong_hieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double tong, hieu;
            Console.WriteLine("Nhập vào tổng hai số");
            tong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào hiệu hai số");
            hieu = double.Parse(Console.ReadLine());
            double x = (tong + hieu) / 2;
            double y = tong - x;
            Console.WriteLine("Gía trị của x cần tìm là:" + x);
            Console.WriteLine("Gía trị của y cần tìm là:" + y);
            Console.ReadLine();
        }
    }
}
