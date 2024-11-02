using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huong_doi_tuong
{
    //#regin    #enregion để rút gọn
    internal class SinhVien
    {
        #region biến lớp
        //Khai báo biến lớp
        private int maSV;
        private string tenSV;
        private float diemThiDH;
        #endregion
        #region contructor
        //Khai báo contructor
        //(Gán giá trị mặc định cho đối tượng)
        public SinhVien()
        {
            //Khi người dùng chưa gán giá trị vào thì đây là default
            this.maSV = 0;
            this.tenSV = "No name";
            this.diemThiDH = 0;
        }

        //Khai báo contructor
        //(Khởi tạo giá trị cho đối tượng do người dùng truyền vào) cho phép gán giá trị 
        public SinhVien(int maSV, string tenSV,float diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH=diemThiDH;
        }
        #endregion
        #region Properties
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
        public float DiemThiDH
        {
            get { return diemThiDH; }
            set { diemThiDH = value;}
        }
        #endregion
        #region method
        //Phương thức tostring
        public override string ToString() 
        {
            return this.MaSV + "\t" + this.TenSV + "\t" + this.DiemThiDH;
        }

        //support method : không truy xuất được từ bên ngoài lớp (private)
        //Kiểm tra điều kiện sinh viên mới
        private bool CheckDiemThiDH()
        {
            return (this.diemThiDH -21 >= 0);
        }

        //service method : Truy xuất được bên ngoài (public)
        public void XuatThongTin()
        {
            if(CheckDiemThiDH() == false)
                Console.WriteLine("Điểm thi DH<21, cần kiểm tra lại HS sv này");
            else
                Console.WriteLine(ToString());
        }

        //Overloading Method: Trong cùng một class có nhiều phương thức cùng tên nhưng khác nhau về Signature\
        //Signature gọi là khác nhau khi chúng khác nhau về
        //1.Số lượng các đối số
        //2.Kiểu dữ liệu các đối số
        //3.Thứ tự các đối sốs
        //Contructor: là trường hợp đặc biệt của Overloading Method

        //tổng
        public int Tong(int x,int y)
        {
            return x + y;
        }

        public int Tong(int x, int y, int z)
        {
            return x + y + z;
        }

        public double Tong(double x, double y, double z)
        {
            return x + y + z;
        }

        //Parametter List Method: 
        //Tính tổng điểm trung bình học kỳ
        public float TBKetThucHocKy(params float[] mang)
        {
            float s = 0;   
            foreach (float f in mang)
            {
                s += f;
            }
            return (s/mang.Count());
        }
        #endregion
    }
}
