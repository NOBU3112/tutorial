using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai báo
            char ch1 = 'a';//Khai báo buộc phải dùng ''
            Console.WriteLine(ch1);
            Console.WriteLine(ch1.GetType().ToString());

            //cách2
            char ch2 = (char)65; //bảng mã ASCII
            Console.WriteLine(ch2);
            Console.WriteLine(ch2.GetType().ToString());

            //ép kiểu chả cho dữ liệu nhập vào
            char ch3 = char.Parse("b");//sẽ bị lỗi nếu có nhiều hơn 1 ký tự
            Console.WriteLine(ch3);
            Console.WriteLine(ch3.GetType().ToString());

            //Chuyển đổi kiểu dữ liệu
            char ch4 = Convert.ToChar("t");//cũng cần phải chỉ có 1 ký tự
            Console.WriteLine(ch4);
            Console.WriteLine(ch4.GetType().ToString());

            //So sánh hai ký tự
            char ch7 = 'a';//=97 (ASCII)
            char ch8 = 'b';//=98
            char ch9 = 'a';//=97
            char ch10 = 'm';//=109
            Console.WriteLine(ch7.CompareTo(ch8));//=97-98=-1
            Console.WriteLine(ch8.CompareTo(ch7));//=1
            Console.WriteLine(ch7.CompareTo(ch9));//=0
            Console.WriteLine(ch7.CompareTo(ch10));//=-12

            //So sánh sử dụng (Equals)->Trả về true hoặc false
            Console.WriteLine(ch7.Equals(ch10));//false
            Console.WriteLine(ch7.Equals(ch9));//true

            //char method - Các phương thức
            Console.WriteLine(char.IsDigit('2'));//Chữ số
            Console.WriteLine(char.IsLetter('e'));//Chữ cái
            Console.WriteLine(char.IsWhiteSpace(' '));//khoảng trắng
            Console.WriteLine(char.IsLower('a'));//Ký tự viết thường
            Console.WriteLine(char.IsUpper('A'));//ký tự viết hoa
            Console.WriteLine(char.ToUpper('a'));//chuyển ký tự ra in hoa
            Console.WriteLine(char.ToLower('A'));//chuyển ký tự ra in thường
            Console.ReadKey();

        }
    }
}
