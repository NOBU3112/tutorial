using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // in ra số nhỏ thứ 2 và số lớn thứ 2 trong list
            Console.OutputEncoding = Encoding.UTF8;
            List<int> list = new List<int>() { 1,2,3,4,5,7,6,4,23};
            List<int> list2 = new List<int>();
            list2.AddRange(list);
            Console.WriteLine("Danh sách 2 bạn vừa copy là:");
            list2.Remove(list2.Max());
            list2.Remove(list2.Min());
            foreach (int i in list2)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Phần tử lớn thứ 2 trong danh sách là:" + list2.Max());
            Console.WriteLine("Phần tử nhỏ thứ 2 trong danh sách là:" + list2.Min());
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i]==list2.Min())
                    Console.WriteLine("Vị trí index của số nhỏ thứ 2 trong danh sách là: " + i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == list2.Max())
                    Console.WriteLine("Vị trí index của số lớn thứ 2 trong danh sách là: " + i);
            }
            Console.ReadKey();
        }
    }
}
