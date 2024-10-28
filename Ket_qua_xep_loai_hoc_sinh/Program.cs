using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ket_qua_xep_loai_hoc_sinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float dtb;
            Console.WriteLine("Nhập vào điểm trung bình");
            dtb = float.Parse(Console.ReadLine());
            String kq = (dtb >= 8) ? "Giỏi" : (dtb >= 6.5) ? "Khá" : (dtb >= 5) ? "Trung bình" : "Yếu";
            Console.WriteLine("Điểm trung bình của bạn là " + dtb + ",bạn xếp loại " + kq);
            Console.ReadLine();
        }
    }
}
