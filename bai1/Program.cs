using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;//Xuất được tiếng việt
            Console.Write("Hello");
            Console.WriteLine("Xin chào, mình mới học C#");
            Console.WriteLine(200);
            //Console.ReadLine();
            Console.ReadKey(true);
            Console.WriteLine("Họ và tên : Nguyễn Tuấn Đạt");
            Console.WriteLine("Năm sinh: " + 31 + "/" + 12 + "/" + 2003);
            Console.WriteLine("Giới tính: Nam");
            Console.WriteLine("Tuổi của bạn : 20");
            Console.ReadLine();
        }
    }
}
