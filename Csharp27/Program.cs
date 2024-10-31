using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình nhập list, in ra có bao nhiêu số nhỏ hơn 5 in ra vị trí
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập vào số phần tử trong danh sách:");
            n=int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập vào phần tử thứ {0} của danh sách:" , i+1);
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Danh sách bạn vừa nhập là:");
            foreach (int i in list)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            int dem = 0;
            foreach (int i in list) 
            {
                if (i < 5)
                    dem++;
            }
            Console.WriteLine("Có {0} phần tử nhỏ hơn 5 trong danh sách",dem);
            Console.WriteLine("Vị trí index của các số nhỏ hơn 5 trong danh sách là:");
            for (int i = 0;i < list.Count; i++)
            {
                if (list[i]<5)
                    Console.Write(i+ " ");
            }
            Console.ReadKey();
        }
    }
}
