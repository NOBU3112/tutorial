using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Chương trình yêu cầu nhập vào username và pass (dic)
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("user1", "123456");
            dic.Add("user2", "123456");
            dic.Add("user3", "123456");
            dic.Add("user4", "123456");
            dic.Add("user5", "123456");
            foreach (KeyValuePair<string,string> pair in dic) 
            {
                Console.WriteLine(pair);
            }

            Console.WriteLine("Mời nhập vào username:");
            string user = Console.ReadLine();
            Console.WriteLine("Mời nhập vào mật khẩu:");
            string mk = Console.ReadLine();
            if(dic.ContainsKey(user) == false)
            {
                Console.WriteLine("User không tồn tại");
            }
            else
            {
                if (dic[user] == mk)
                    Console.WriteLine("Đăng nhập thành công");
                else
                    Console.WriteLine("Mật khẩu không đúng");
            }
            Console.ReadKey();
        }
    }
}
