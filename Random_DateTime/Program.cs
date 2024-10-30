using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random
            Console.OutputEncoding = Encoding.UTF8;
            Random rd = new Random(); //cú pháp tạo ra 1 đối tượng có thể sinh ra 1 số ngẫu nhiên
            //random số ngẫu nhiên
            //(begin,sát end) begin không nhập thì mặc định begin = 0
            int soNgauNhien = rd.Next(50,101);//50-100
            Console.WriteLine("Số ngẫu nhiên máy sinh ra là: " + soNgauNhien);

            //muốn lấy số ngẫu nhiên nằm trong đoạn (0,1)
            double k2 = rd.NextDouble();
            Console.WriteLine("Số ngẫu nhiên 2 là " + k2);

            //1.312321311
            double k3 = k2 + soNgauNhien;
            Console.WriteLine("giá trị ngẫu nhiên mong muốn là: " + k3);

            //cách 2
            double k4 = k2 * 10;
            Console.WriteLine("Giá trị ngẫu nhiên 2 mong muốn là: " + k4);
            Console.WriteLine();

            //DateTime
            DateTime birthday = new DateTime(1987, 11, 21);//nam,thang,ngay
            Console.WriteLine("Ngày tháng năm sinh của bạn là: " + birthday.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngày sinh của bạn là: " + birthday.ToString("dd"));
            Console.WriteLine("Tháng sinh của bạn là: " + birthday.ToString("MM"));
            Console.WriteLine("Năm sinh của bạn là: " + birthday.ToString("yyyy"));

            DateTime birthday2 = DateTime.Parse("11/24/1992");//tháng,ngày,năm
            Console.WriteLine("ngày tháng năm sinh 2 của bạn là: " + birthday2.ToString("MM/dd/yyyy"));

            //Viết chương trình cho người đăng nhập vào ngày tháng năm sinh
            Console.WriteLine("Mời bạn nhập vào ngày tháng năm sinh (tháng/ngày/năm):  ");
            string s = Console.ReadLine();
            DateTime birthday3 = DateTime.Parse(s);//phải ở dạng tháng,ngày,năm
            Console.WriteLine("Ngày sinh của bạn là: " + birthday3.ToString("dd"));
            Console.WriteLine("Tháng sinh của bạn là: " + birthday3.ToString("MM"));
            Console.WriteLine("Năm sinh của bạn là: " + birthday3.ToString("yyyy"));
            Console.ReadKey();
        }
    }
}
