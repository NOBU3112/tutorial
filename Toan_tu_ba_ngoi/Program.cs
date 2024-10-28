using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toan_tu_ba_ngoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nhập vào một số n: kiểm tra n là chẵn hay lẻ
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhap vao so nguyen n:");
            n = int.Parse(Console.ReadLine());
            String traLoi = (n % 2 == 0) ? "Số chẵn" : "Số lẻ"; // biến = (đk)? nếu đúng : nếu sai
            Console.WriteLine("Số {0} là {1}",n,traLoi);
            Console.ReadLine();
        }
    }
}
