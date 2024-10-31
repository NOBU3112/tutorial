using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // trả lời list quest ={"2+5+7=","5*10=","sqrt(16)=","12%2=","5//2="}
            Console.OutputEncoding = Encoding.UTF8;
            List<string> quest = new List<string>() { "2+5+7=", "5*10=", "sqrt(16)=", "12%2=", "5//2=" };
            List<int> traloi = new List<int>() { 14, 50, 4, 0, 2 };
            for (int i = 0; i < quest.Count; i++)
            {
                Console.WriteLine(quest[i]);
                int ans = int.Parse(Console.ReadLine());
                if(ans == traloi[i])
                    Console.WriteLine("Corect");
                else
                    Console.WriteLine("wrong, Câu trả lời là " + traloi[i]);
            }
            Console.ReadKey();
        }
    }
}
