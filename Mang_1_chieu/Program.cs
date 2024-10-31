using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_1_chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Khai báo mảng
            int[] stt;
            char[] ch;
            string[] ten;

            //Khởi tạo bảng
            //tên mảng = new Kiểu dữ liệu [Số phần tử]
            stt = new int[5]; //Mặc định các phàn tử = 0
            foreach (int i in stt)
            {
                Console.Write(i + " " );
            }
            Console.WriteLine();
            Console.WriteLine("Mảng stt2 là: ");
            int[] stt2 = new int[7];
            foreach (int i in stt2)
            {
                Console.Write(i + " " );
            }

            //Khởi tạo và gán luôn giá trị cho mảng
            //Kiểu dữ liêu[] tên bảng = new kiểu dữ liệu[Số phần tử]{p1,p2p3,...};
            int[] mang2 =new int[7] { 1, 2, 3, 4, 5, 6, 7 };//phải đúng số phần tử
            //int [] mang2 = {1,2,3,4,4,5,6,,7,7,8,88} hoặc có thể khai báo kiểu này
            Console.WriteLine();
            Console.WriteLine("Mảng 2 là: ");
            foreach(int i in mang2)
            {
                Console.Write(i + " " );
            }

            //Khởi tạo một mảng ngẫu nhiên
            Random r = new Random();
            int[] mang3 = new int[2] { r.Next(51), r.Next(61) };
            Console.WriteLine();
            Console.WriteLine("Mảng 3 là: ");
            foreach (int i in mang2)
            {
                Console.Write(i + " ");
            }

            //Length kiểm tra độ dài
            int dai = mang3.Length;
            Console.WriteLine();
            Console.WriteLine("Chiều dài của mảng 3 là:" + dai);

            //Truy xuất phần tử qua index
            int[] mang4 = { 1, 3, 5 };
            Console.WriteLine(mang4[0]);
            Console.WriteLine(mang4[1]);
            Console.WriteLine(mang4[2]);
            Console.WriteLine(mang4[mang4.Length-1]);

            //Thay đổi giá trị phần tử mảng bằng cách gọi index
            int[] mang5 = { 1, 3, 5, 9, 8 };
            mang5[1] = 100;
            Console.WriteLine("Mảng 5 sau khi thay đổi giá trị là: ");
            foreach (int i in mang5)
            {
                Console.Write(i + " ");
            }

            //duyệt mảng bằng for (duyệt theo index)
            Console.WriteLine();
            int[] mang6 = { 1, 3, 5, 8, 6 };
            for(int i = 0; i < mang6.Length; i++)
            {
                Console.Write(mang6[i] + " ");
            }
            Console.WriteLine();

            //Phép gán mảng
            //CHÚ Ý :khi thay đổi giá trị của 1 mảng thì mảng còn lại cũng thay đổi
            int[] mang8 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] mang9 = mang8;
            mang8[0] = 100;
            Console.WriteLine("Mảng 8 sau khi thay đổi index0 là: " + mang8[0]);
            Console.WriteLine("Mảng 9 sau khi thay đổi index0 là: " + mang9[0]);

            //Copyto(tên mảng,vị trí copy đến)  copy ra mảng mới trên vùng nhớ mới(không thay đổi nếu cái còn lại thay đổi)
            int[] mang10 = { 100, 200, 300, 400 };
            int[] mang11 = { 1, 2, 3, 4, 5, 6, 7 };
            mang10.CopyTo(mang11, 2); //không copyto nếu  mang11 vượt quá length  ban đầu
            Console.WriteLine("Mảng 11 sau khi thay đổi giá trị là: ");
            foreach (int i in mang11)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Copy(mảng nguồn,mảng đích,lấy mấy phần từ bắt đầu từ index 0)
            int[] mang12 = { 100, 200, 300, 400 };
            int[] mang13 = new int[4];
            Array.Copy(mang12, mang13, 3);
            Console.WriteLine("Mảng 13 là: ");
            foreach (int i in mang13)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Clone (tạo mảng mới copy từ mảng cũ trên bộ nhớ mới)
            int[] mang14 = { 1, 3, 3, 214, 12412, 4 };
            int[] mang15 = (int[])mang14.Clone();
            Console.WriteLine("Mảng 15 là: ");
            foreach (int i in mang15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Array.Reverse Đảo ngược mảng
            int[] mang16 = { 1, 2, 3, 24, 12, 4, 214 };
            Array.Reverse(mang16);
            Console.WriteLine("Mảng 16 là: ");
            foreach (int i in mang16)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Array.Sort (Sắp xếp mảng tăng đần)
            int[] mang17 = { 1, 5, 2, 6, 8, 32, 6, 2, 8, 56, 32, 2 };
            Array.Sort(mang17);
            Console.WriteLine("Mảng 17 là: ");
            foreach (int i in mang17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //VD vận dụng
            //1. Viết chương trình tạo 1 mảng 1 chiều gồm các phần tử là số nguyên, có n phần tử ngẫu nhiên, n do người dùng nhập từ bàn phím
            int n;
            Console.WriteLine("Mời nhập vào số phần tử của mảng");
            n = int.Parse(Console.ReadLine());
            int[] Mang = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                Mang[i] = rd.Next(101);
            }
            Console.WriteLine("Mảng ngẫu nhiên là: ");
            foreach (int i in Mang)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Đảo ngược mảng
            Array.Reverse(Mang);
            Console.WriteLine("Mảng sau khi đảo ngược là: ");
            foreach (int i in Mang)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Sắp xếp mảng
            Array.Sort(Mang);
            Console.WriteLine("Mảng sau khi sắp xếp là: ");
            foreach (int i in Mang)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Tính tổng các phần tử
            int tong = 0;
            foreach (int i in Mang)
                tong+=i;
            Console.WriteLine("Tổng các phần tử của mảng là: " + tong);

            //Tìm kiếm mảng
            Console.WriteLine("Mời nhập vào số cần tìm: ");
            int so = int.Parse(Console.ReadLine());
            //Cách 1:
            int kq = Array.BinarySearch(Mang, so); //không tìm thấy = -1, tìm thấy = index; Phải sắp xếp trc mới dùng đc
            if (kq < 0)
                Console.WriteLine("Không tìm thấy");
            else
                Console.WriteLine("Tìm thấy số {0} ở vị trí index {1}",so,kq);

            //Cách 2:
            int demkq = 0;
            for (int i =0; i < n; i++)
            {
                if (Mang[i] == so)
                {
                    Console.WriteLine("Tìm thấy {0} tại vị trí {1}",so,i);
                    demkq++;
                }
            }
            if(demkq == 0)
                Console.WriteLine("Không tìm thấy");
            Console.ReadKey();
        }
    }
}
