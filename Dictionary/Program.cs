using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Khai báo
            Dictionary<int,string> dic = new Dictionary<int,string>();
            //khởi tạo gán giá trị
            Dictionary<int, string> dic2 = new Dictionary<int, string>() { {1,"obamma" },{2,"javkma" } };
            //key: biển số xe (kiểu string)
            //value: chứng minh thư int
            Dictionary<string, int> dic3 = new Dictionary<string, int>() { { "3123H31",01923 }, { "31573J",12421 } };

            //Add Thêm phần tử
            dic.Add(1, "Lo văn mới");
            dic.Add(2, "Lo an mới");
            dic.Add(3, "Lo văn da");

            //Duyêt dic
            foreach (KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine(kvp);
                //Console.WriteLine(kvp.Key);
                //Console.WriteLine(kvp.Value);
                Console.WriteLine("key = {0}, value = {1}",kvp.Key,kvp.Value);
            }

            //dic.ContainsKey()   Kiểm tra xem 1key có tồn tại trong dic không ra true false
            bool kq = dic.ContainsKey(1);
            Console.WriteLine("kq1=" + kq);

            //dic.ContainsValue()   Kiểm tra xem 1 value có tồn tại trong dic không ra true false
            bool kq2 = dic.ContainsValue ("đá");
            Console.WriteLine("kq2=" + kq2);

            // dic[key] lấy giá trị từ key
            string name = dic[1];
            Console.WriteLine(name);

            //gán giái trị
            dic[2] = "đôủ nfa";
            Console.WriteLine(dic[2]);

            // Xóa phần tử theo key
            dic.Remove(2);
            Console.WriteLine("dic sau khi xóa là:");
            foreach(KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine(kvp);
            }

            //clear() Xóa toàn bộ phần tử
            Console.WriteLine("Số phần tử của dic trước khi xóa là: " + dic.Count());
            dic.Clear();
            Console.WriteLine("Số phần tử của dic sau khi xóa là: " + dic.Count());

            // Chuyển values dic => list
            Dictionary<string, int> dic4 = new Dictionary<string, int>() { { "3123H31", 01923 }, { "31573J", 12421 } };
            List<int> ds = new List<int>();
            ds = dic4.Values.ToList();
            Console.WriteLine("Danh sách value là:");
            foreach(int i in ds)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            // Chuyển values dic => list
            List<string> dskey = new List<string>();
            dskey = dic4.Keys.ToList();
            Console.WriteLine("Danh sách key là:");
            foreach (string i in dskey)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
