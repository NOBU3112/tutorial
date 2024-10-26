using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soluong = 0; // khoi tao bien
            float diemTrungBinh = 31.2f; // 31.4 se bi coi la double neu khong co f
            String name = "Toan";
            byte tuoi; // khai bao bien
            int x4;
            Console.WriteLine($"So luong la : {soluong}");
            Console.WriteLine("tuoi: " + name);
            Console.WriteLine("So luong la : {0}, diem trung binh la : {1}", soluong, diemTrungBinh);
            Console.ReadLine();

            int a = 1;
            int b = 2;
            float z = a / b;
            Console.WriteLine("Gia tri cua z la:" + z);
            float z2 = (float)a / b;
            Console.WriteLine("Gia tri cua z la:" + z2);

            byte x = 255;
            int y = x;//int>byte

            int k = 400000;
            Console.WriteLine("Gia tri cua k la: " + k);
            //byte l =k; loi
            byte l = (byte)k;
            Console.WriteLine("Gia tri cua k la: " + l);//l=128 
            Console.ReadLine();

            //vd van dung
            String hoTen;
            float diemToan;
            float diemVan;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời nhập vào họ tên :");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhập diểm toán :");
            diemToan = float.Parse(Console.ReadLine()); //ep String -> float
            Console.WriteLine("Nhập điểm văn :");
            diemVan = float.Parse(Console.ReadLine());
            Console.WriteLine("Học sinh {0} có điểm toán là {1}, điểm văn là {2}", hoTen, diemToan, diemVan);
            Console.ReadLine();

            var m = 113;  // m get int32
            Console.WriteLine("Kieu du lieu cua  m la {0}", m.GetType().ToString());
            var n = "toan"; //n get String
            Console.WriteLine("Kieu du lieu cua  m la {0}", n.GetType().ToString());
            var h = 15.3; // h get double
            Console.WriteLine("Kieu du lieu cua  m la {0}", h.GetType().ToString());
            Console.ReadKey();
        }
    }
}
