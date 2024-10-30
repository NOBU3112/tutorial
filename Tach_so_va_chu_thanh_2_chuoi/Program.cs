using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tach_so_va_chu_thanh_2_chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string chuoi, chuoiSo ="", chuoiChu ="";
            Console.WriteLine("Nhập vào một chuỗi: ");
            chuoi = Console.ReadLine();
            foreach(char c in chuoi) 
            {
                if (char.IsDigit(c))
                    chuoiSo += c;
                else if (char.IsLetter(c))
                    chuoiChu += c;
                else if (char.IsWhiteSpace(c))
                {
                    chuoiSo += c;
                    chuoiChu += c;
                }    

            }
            Console.WriteLine("Chuỗi chỉ gồm số là: " + chuoiSo);
            Console.WriteLine("Chuỗi chỉ gồm chư cái là: " +chuoiChu);
            Console.ReadKey();

        }
    }
}
