using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float diemTN;
            Console.WriteLine("nhap diem tot nghiep: ");
            diemTN = float.Parse(Console.ReadLine());

            if (diemTN > 7)
            {
                Console.WriteLine("Diem tot nghiep cua ban la {0} ,ban da do", diemTN);
                Console.WriteLine("day la dong lenh thu 2");
            }
            else
                Console.WriteLine("Diem tot nghiep cua ban la {0} ,ban da tach", diemTN);
            Console.WriteLine("het chuoung trinh roi");
            Console.ReadKey();

            float dtb;
            Console.WriteLine("nhap vao diem tb :");
            dtb = float.Parse(Console.ReadLine());
            if (dtb >= 8)
                Console.WriteLine("xep loai gioi");
            else if (dtb >= 6.5 && dtb < 8)
                Console.WriteLine("xep loai kha");
            else if (dtb >= 5 && dtb < 6.5)
                Console.WriteLine("xep loai kha");
            else
                Console.WriteLine("xep loai yeu");
            Console.ReadKey();
        }
    }
}
