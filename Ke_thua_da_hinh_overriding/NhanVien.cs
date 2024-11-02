using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_thua_da_hinh_overriding
{
    public class NhanVien
    {
        //khởi tạo
        public int MaNV { get; set; }
        public string TenNV { get; set; }

        //phương thức tính lương NV
        public double TinhLuong()
        {
            return 1000;
        }

        //hàm ảo virtual
        public virtual double ThuongDuCong(int ngayCong)
        {
            if (ngayCong >= 26)
                return 100;
            else
                return 0;
        }
    }
}
