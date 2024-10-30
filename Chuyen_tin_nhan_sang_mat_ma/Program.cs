using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuyen_tin_nhan_sang_mat_ma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "zxcvbnmasdfghjklqwertyuiop";
            Console.WriteLine("Mời nhập vào chuỗi cần mã hóa");
            string chuoiInput = Console.ReadLine();
            string chuoiOutput = "";
            foreach (char c in chuoiInput) 
            {
                int indexKytu = a.IndexOf(c);
                chuoiOutput += b[indexKytu];
            }
            Console.WriteLine("Chuỗi trước mã hóa là: " + chuoiInput);
            Console.WriteLine("Chuỗi sau mã hóa là: " + chuoiOutput);
            Console.ReadLine();
        }
    }
}
