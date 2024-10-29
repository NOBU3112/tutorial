using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_foreach_continue_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for
            //Xuất các số chẵn từ 0-10
            int tong = 0;
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i <= 10; i += 2)
            {
                tong += i;
                Console.WriteLine("i = " + i);
                Console.WriteLine("Tổng:" + tong);
            }
                Console.ReadLine();

            //foreach
            int thang;
            Console.WriteLine("Nhập vào tháng:");
            thang = int.Parse(Console.ReadLine());
            int[] lst = { 1, 3, 5, 7, 9 }; //Khởi tạo 1 list
            foreach (int i in lst)
            {
                Console.WriteLine("i = " +i);
                if (thang == i)
                {
                    Console.WriteLine("Tháng bạn nhập có 31 ngày");
                    break;
                }
            }
            String[] lstS = { "HAHA", "HELLO", "SCHOOL" };
            foreach (String i in lstS)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //continue
            //Tính tổng các số từ 1 đến 5 nhưng ko lấy 3
            int tong1 = 0;
            for (int i = 0;i<=5;i++)
            {
                if(i == 3) 
                {
                    continue; //nếu i=3 thì nó sẽ bỏ qua
                }
                Console.WriteLine("i= " + i);
                tong1 += i;
            }
            Console.WriteLine("Tổng cần tìm là "+tong1);
            Console.ReadLine() ;

            //break
            //Tính tổng các số từ 1 đến 5 nhưng chỉ cộng đến 3 thì thoát luôn
            int tong2 = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                {
                    break; //nếu i=3 thì nó sẽ dừng vòng lặp luôn
                }
                Console.WriteLine("i= " + i);
                tong2 += i;
            }
            Console.WriteLine("Tổng cần tìm là " + tong2);
            Console.ReadLine();
        }
    }
}
