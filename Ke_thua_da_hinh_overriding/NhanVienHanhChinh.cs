using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_thua_da_hinh_overriding
{
    public class NhanVienHanhChinh: NhanVien //NhanVienHanhChinh là con của lớp NhanVien
    {
        public override double ThuongDuCong(int ngayCong) //nếu gọi NhanVien nv2 = new NhanVienHanhChinh thì nv2.ThuongDuCong(); sẽ là ThuongDuCong() của NhanVienHanhChinh
        {
        {
            return 0;
        }
    }
}
