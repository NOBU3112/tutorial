using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Mời nhập vào số phần tử của danh sách:");
            n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập vào phần tử thứ {0} của danh sách",i+1 );
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("List bạn vừa nhập là:");
            foreach (int i in list)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();
            List<int> list2 = new List<int>();
            foreach(int i in list)
            {
                list2.Add(i*i); //Nếu dùng Math.Pow phải dùng double
            }
            int dem=0;
            Console.WriteLine("List 2 là:");
            foreach (int i in list2)
            {
                if (i >= 50)
                    dem++;
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Số phần tử lớn hơn 50 trong danh sách 2 là: " + dem);
            Console.ReadKey();
            
        }
    }
}
