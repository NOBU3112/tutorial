using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xu_ly_ngoai_le
{
    internal class Program
    {
        static void NgoaiLe()
        {
            try
            {
                Console.WriteLine("Mời nhập vào ngày tháng năm sinh");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("Ngày sinh của bạn là: " + birthday.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally //Có lỗi vẫn chạy
            {
                Console.WriteLine("Cảm ơn các bạn đã sử dụng phần mềm");
            }
        }

        //throw statement
        static void NgoaiLe2() 
        {
            Console.WriteLine("Mời nhập vào tử số : ");
            int tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập vào mẫu số");
            int mau = int.Parse(Console.ReadLine());
            if(mau == 0 )
                throw new ArithmeticException("Lỗi mẫu bằng 0 rồi");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NgoaiLe();


            try
            {
                NgoaiLe2();
            }
            catch (ArithmeticException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
