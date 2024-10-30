using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dem_so_tu_trong_cau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string a = @"tôi chăm học
                         tôi chịu khó
                         tôi đẹp trai";
            int dem = 0;
            string[] stl = a.Split(' ');
            foreach (string s in stl)
            {
                if ("tôi".Equals(s))
                    dem++;
            }
            Console.WriteLine("Có {0} từ tôi ở trong a",dem);
            Console.ReadKey();

        }
    }
}
