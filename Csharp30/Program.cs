using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<string, int> dic = new Dictionary<string, int>() { {"A",1}, { "B", 2 }, { "C", 3 }, { "D", 2 }, { "E", 1 }, { "F", 4 }, { "G", 2 }, { "H", 4 },
            { "I", 1 }, { "J", 8 }, { "K", 5 }, { "L", 1 }, { "M", 3 }, { "N", 1 }, { "O", 1 }, { "P", 3 }, { "Q", 10 },
            { "R", 1 }, { "S", 1 }, { "T", 1 }, { "U", 1 }, { "V", 4 },{"W",4},{"X",8},{"Y",4},{"Z",10} };
            1. Tách số và chữ, hiển thị lên màn hình
            2.Tính tổng các số
            3.Chuyển đổi chuỗi: "University of Technology and Education" sang số
            */
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, int> dic = new Dictionary<string, int>() { {"A",1}, { "B", 2 }, { "C", 3 }, { "D", 2 }, { "E", 1 }, { "F", 4 }, { "G", 2 }, { "H", 4 },
            { "I", 1 }, { "J", 8 }, { "K", 5 }, { "L", 1 }, { "M", 3 }, { "N", 1 }, { "O", 1 }, { "P", 3 }, { "Q", 10 },
            { "R", 1 }, { "S", 1 }, { "T", 1 }, { "U", 1 }, { "V", 4 },{"W",4},{"X",8},{"Y",4},{"Z",10} };
            foreach(KeyValuePair<string,int>kvp in dic) 
            {
                Console.Write(kvp + " ");
            }
            Console.WriteLine();

            //1
            List<string> chuCai = dic.Keys.ToList();
            List<int> listSo = dic.Values.ToList();
            Console.WriteLine("Các chữ cái trong dic là:");
            foreach(string chu in chuCai)
            {
                Console.Write(chu.PadRight(3));
            }
            Console.WriteLine();
            Console.WriteLine("Các số trong dic là:");
            foreach (int so in listSo)
            {
                Console.Write(so.ToString().PadRight(3));//PadRight căn phải 3 space
            }
            Console.WriteLine();

            //2.Tính tổng các số
            int tong=0;
            //int tong = listSo.Sum()
            foreach (KeyValuePair<string,int> kvp in dic)
            {
                tong += kvp.Value;
            }
            Console.WriteLine("Tổng các số trong dic là:" + tong);

            //Chuyển đổi chuỗi: "University of Technology and Education" sang số
            string chuoi = "University of Technology and Education";

            string chuoiTemp = chuoi.ToUpper();
            string chuoiSo = "";
            foreach(char chu in chuoiTemp)
            {
                if (char.IsWhiteSpace(chu))
                    chuoiSo += chu;
                else
                    chuoiSo += dic[chu.ToString()];
            }
            Console.WriteLine("Chuỗi cần chuyển khi viết hoa là:");
            Console.WriteLine(chuoiTemp);
            Console.WriteLine(chuoiSo);
            Console.ReadKey();

        }
    }
}
