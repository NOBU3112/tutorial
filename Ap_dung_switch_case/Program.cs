using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap_dung_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            Console.WriteLine("CHƯƠNG TRÌNH TÌM KIẾM");
            Console.WriteLine("1. Tìm kiếm theo tên");
            Console.WriteLine("2. Tìm kiếm theo tác giả");
            Console.WriteLine("3. Tìm kiếm theo nhà xuất bản");
            Console.WriteLine("4. Tìm kiếm theo tiêu đề");
            Console.WriteLine("Bấm phím để lựa chọn");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("1. Tìm kiếm theo tên");
                    break;
                case 2:
                    Console.WriteLine("2. Tìm kiếm theo tác giả");
                    break;
                case 3:
                    Console.WriteLine("3. Tìm kiếm theo nhà xuất bản");
                    break;
                case 4:
                    Console.WriteLine("4. Tìm kiếm theo tiêu đề");
                    break;
                default:
                    Console.WriteLine("Phím bấm không hợp lệ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
