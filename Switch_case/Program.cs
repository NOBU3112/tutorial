using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào 1 số kiểm tra chẵn lẻ
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            Console.WriteLine("Mời nhập vào số nguyên a: ");
            a = int.Parse(Console.ReadLine());
            int div = a % 2;
            switch (div)
            {
                case 0:
                    Console.WriteLine("Số {0} là số chẵn", a);
                    goto case 1; //Chuyển ra thực hiện case 1
                case 1:
                    Console.WriteLine("Chuyển tiếp");
                    break; // Thoát ra hỏi switch case
                default:
                    Console.WriteLine("Số {0} là số lẻ", a);
                    break;
            }
            Console.ReadKey();

            //Thay màu text hiển thị
            Console.ForegroundColor = ConsoleColor.Red;//đổi màu ký tự
            Console.WriteLine("CHƯƠNG TRÌNH TÌM KIẾM");
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.White;//đổi màu phông chữ
            Console.WriteLine("1. Tìm kiếm theo tên");
            Console.WriteLine("2. Tìm kiếm theo tác giả");
            Console.WriteLine("3. Tìm kiếm theo nhà xuất bản");
            Console.WriteLine("4. Tìm kiếm theo tiêu đề");
            Console.ReadKey();
        }
    }
}
