using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* str1 = "English = 78 Science = 83 Math = 68 History = 65"
             * 1.Tính tổng các số trong chuỗi trên
             * 2.Tính trung bình cộng
             */
            Console.OutputEncoding = Encoding.UTF8;
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] lst = str1.Split(' ');
            string strSo = "";
            foreach (string x in lst) 
            {
                //Console.WriteLine(x);
                foreach(char c in x)
                {
                    if (char.IsDigit(c))
                    {
                        strSo += x + " ";
                        break;
                    }
                }
            }
            Console.WriteLine(strSo);
            strSo = strSo.Trim();
            String[] lst2 = strSo.Split(' ');
            int tong = 0;
            foreach (string y in lst2)
            {
                //Console.WriteLine(y);
                tong += int.Parse(y);
            }
            Console.WriteLine("Tổng = " + tong);
            Console.WriteLine("Trung bình cộng = " + (float)tong/lst2.Length);
            Console.ReadKey();
        }
    }
}
