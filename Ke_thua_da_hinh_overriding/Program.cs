using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_thua_da_hinh_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NhanVien nv1 = new NhanVien();
            nv1.TenNV = "Nhân viên 1";
            nv1.MaNV = 1;
            Console.WriteLine("tên nhân viên là:" + nv1.TenNV + " với mã là " + nv1.MaNV);
            Console.WriteLine("Lương nhân viên 1 là: "+ nv1.TinhLuong());

            NhanVienHanhChinh hc1 = new NhanVienHanhChinh();
            hc1.TenNV = "Hành văn chính";
            hc1.MaNV = 2;
            Console.WriteLine("tên nhân viên là:" + hc1.TenNV + " với mã là " + hc1.MaNV);
            Console.WriteLine("Lương nhân viên 2 là: "+ hc1.TinhLuong());

            NhanVienDiCa dc11 = new NhanVienDiCa();
            dc11.TenNV = "Di ca";
            dc11.MaNV = 3;
            Console.WriteLine("tên nhân viên là:" + dc11.TenNV + " với mã là " + dc11.MaNV);

            NhanVienDiCa ca1 = new NhanVienDiCa();
            ca1.TenNV = "Nguyễn Văn Ca";
            ca1.MaNV = 4;
            ca1.ca = "Ca ngày";
            Console.WriteLine("tên nhân viên là:" + ca1.TenNV + " với mã là " + ca1.MaNV + " làm " + ca1.ca);
            Console.WriteLine("Lương nhân viên 4 là: " + ca1.TinhLuong());
            Console.WriteLine("********");
            Console.WriteLine(nv1.ThuongDuCong(26));
            Console.WriteLine(hc1.ThuongDuCong(26));
            Console.WriteLine(ca1.ThuongDuCong(26));
            Console.ReadKey();
        }
    }
}
