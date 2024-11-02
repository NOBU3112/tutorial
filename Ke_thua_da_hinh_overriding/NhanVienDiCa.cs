using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_thua_da_hinh_overriding
{
    public class NhanVienDiCa:NhanVien 
    {
        //Khai báo thêm các thuộc tính ca ngày ca đêm
        public string ca {  get; set; }

        //Phương thức tính lương của nhân viên đi ca
        public new double TinhLuong() // nếu gọi NhanVien nv2 = new NhanVienDiCa thì nv2.TinhLuong(); sẽ là TinhLuong() của NhanVien
        {
            return base.TinhLuong()+0.05*base.TinhLuong(); //base gọi về phương thức cha
        }
    }
}
