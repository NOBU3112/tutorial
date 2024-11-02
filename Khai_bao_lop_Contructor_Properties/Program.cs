using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khai_bao_lop_Contructor_Properties
{
    internal class Program
    {
        //Quy tắc đặt tên lớp
        //1.Tên lớp nên là 1 danh từ hoặc một cụm DT,nên viết hoa chữ cái đầu
        //2.Không bắt đầu bằng số, chữ cái  đặc biệt, không trùng với keyword
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo 1 đối tượng mới không truyền giá trị
            SinhVien sv1 = new SinhVien();
            SinhVien sv2 = new SinhVien();

            //Xuất
            Console.WriteLine(sv1.MaSV);
            Console.WriteLine(sv1.TenSV);
            Console.WriteLine(sv2.MaSV);
            Console.WriteLine(sv2.TenSV);
            Console.WriteLine("Tên sinh viên là: " + sv1.TenSV);

            // Taoij 1 đối tượng có truyền gias trị ban đầu.
            SinhVien sv3 = new SinhVien(3,"Nguyễn Văn A");
            Console.WriteLine("Tên sinh viên 3 là: " + sv3.TenSV);

            //Sửa dữ liệu
            sv3.MaSV = 123;
            sv3.TenSV = "OFW";
            Console.WriteLine("Tên sinh viên 3 là: " + sv3.TenSV);
            Console.WriteLine("Mã sinh viên 3 là: " + sv3.MaSV);
            Console.ReadKey();
        }
    }
}
