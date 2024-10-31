using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tao_list_random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Random rnd = new Random();
            Console.WriteLine("Nhập số phần tử n: ");
            n = int.Parse(Console.ReadLine());
            List<int> lst = new List<int>();
            for (int i = 0; i < n; i++)
            {
                lst.Add(rnd.Next(101));
            }
            foreach (int i in lst)
            {
                Console.Write(i + "\t");
            }
            Console.ReadKey();
        }
    }
}
