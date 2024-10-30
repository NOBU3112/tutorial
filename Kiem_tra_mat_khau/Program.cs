using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiem_tra_mat_khau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mk phải trên 6 ký tự có cả chữ và số
            Console.OutputEncoding = Encoding.UTF8;
            string mK;
            Console.WriteLine("Nhập vào mật khẩu (ít nhất 6 ký tự, ít nhất 1 chữ cái, it nhất 1 chữ số)");
            mK = Console.ReadLine();
            bool check = true;
            int demSo =0,demKyTu =0;
            while (check) //check == true
            {
                foreach (char c in mK) 
                {
                    if (char.IsDigit(c))
                        demSo++;
                    else if(char.IsLetter(c))
                        demKyTu++;
                }
                if (mK.Length >=6 && demSo*demKyTu != 0)
                    check = false;
                else
                {
                    Console.WriteLine("Nhập lại mật khẩu (ít nhất 6 ký tự, ít nhất 1 chữ cái, it nhất 1 chữ số)");
                    mK = Console.ReadLine();
                }    
            }
            Console.WriteLine("Bạn đã thiết lập thành công, mk của bạn là " + mK);

            //Đăng nhập nếu đăng nhập sai 5 lần thì thoát chương trình
            string login;
            Console.WriteLine("Mời nhập vào mật khẩu đăng nhập: ");
            login = Console.ReadLine();
            int time = 0;
            while (true)
            {
                if (login.Equals(mK))
                {
                    Console.WriteLine("Đăng nhập thành công");
                    break;
                }
                else
                {
                    time++;
                    if (time < 5)
                    {
                        Console.WriteLine("Nhập lại mật khẩu, nhập sai {0}/5 lần ", time);
                        login = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Bạn đã nhập sai quá 5 lần");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
