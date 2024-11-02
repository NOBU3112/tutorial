using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khai_bao_lop_Contructor_Properties
{
    internal class SinhVien
    {
        //Khai báo biến lớp
        private int maSV;
        private string tenSV;

        //Khai báo contructor
        //(Gán giá trị mặc định cho đối tượng)
        public SinhVien()
        {
            //Khi người dùng chưa gán giá trị vào thì đây là default
            this.maSV = 0;
            this.tenSV = "No name";
        }

        //Khai báo contructor
        //(Khởi tạo giá trị cho đối tượng do người dùng truyền vào) cho phép gán giá trị 
        public SinhVien(int maSV, string tenSV)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
        }

        //Properties giúp ta có thể truy xuất xem,sửa đổi dữ liệu khi sử dụng private
        public string TenSV
        {
            get { return tenSV; } //get giá trị để đọc
            set { tenSV = value; }// set giá trị s
        }
        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
    }
}
