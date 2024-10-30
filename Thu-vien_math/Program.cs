using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thu_vien_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math.pi
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Pi = " + Math.PI);
            Console.WriteLine("Kiể dữ liệu của math.pi = " + Math.PI.GetType().ToString()); //lấy kiểu dữ liệu
            float pi = (float) Math.PI;
            Console.WriteLine("pi sau khi ép kiểu float= " + pi);

            //căn bậc 2
            int a = 4;
            int b = 10;
            Console.WriteLine("Căn bậc 2 của số a là: " + Math.Sqrt(a));
            Console.WriteLine("kiểu dữ liệu của sqrt = " + Math.Sqrt(a).GetType().ToString());

            //Lũy thừa
            Console.WriteLine("2 lũy thừa 3 = " + Math.Pow(2,3));

            //max-min
            Console.WriteLine("Max= " + Math.Max(a,b));

            //Làm tròn
            float c = 1.23456789f;
            Console.WriteLine("Số c sau khi làm tròn 2 chữ số là: " + Math.Round(c,2));

            //sin cos
            Console.WriteLine("sin 30 = " + Math.Sin(30*Math.PI/180)); // Phải dùng radian radian=độ * pi/180
            Console.ReadLine();
        }
    }
}
