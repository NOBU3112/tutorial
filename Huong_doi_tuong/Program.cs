using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huong_doi_tuong
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
            SinhVien sv3 = new SinhVien(3, "Nguyễn Văn A", 6);
            Console.WriteLine("Tên sinh viên 3 là: " + sv3.TenSV);

            //Sửa dữ liệu
            sv3.MaSV = 123;
            sv3.TenSV = "OFW";
            Console.WriteLine("Tên sinh viên 3 là: " + sv3.TenSV);
            Console.WriteLine("Mã sinh viên 3 là: " + sv3.MaSV);

            //Phương thức tostring
            Console.WriteLine(sv1.ToString());
            Console.WriteLine(sv2.ToString());
            Console.WriteLine(sv1);//Viết ngắn gọn
            Console.WriteLine(sv3);

            //service method và support method
            SinhVien sv4 = new SinhVien(3, "Nguyễn Văn B", 21);
            //check điểm
            sv4.XuatThongTin();

            Console.WriteLine(sv4.Tong(1,2));
            Console.WriteLine(sv4.Tong(1,2,3));
            Console.WriteLine(sv4.Tong(1.23,412.2,421.1));


            //Parameter List Method
            Console.WriteLine(sv2.TBKetThucHocKy(4,6,3,7,9,4,5,3,7,6,4));
            Console.WriteLine(sv1.TBKetThucHocKy(10,10,10,10));

            //Auto-Implementedd Properties
            HocSinh hs1 = new HocSinh();
            hs1.Name = "Tèo";
            hs1.Phone = "09xx";
            hs1.Email = "teo@gmail.com";
            Console.WriteLine(hs1);
            Console.ReadKey();
        }
    }
}
