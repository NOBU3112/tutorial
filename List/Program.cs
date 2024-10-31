using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Khởi tạo list
            //List<kieudulieu> tenlist = new List<kieudulieu>()
            List<string> ds1 = new List<string>(); //danh sách các phần tử là string
            List<int> ds2 = new List<int>(); //danh sách int

            //khởi tạo có sẵn phần tử
            List<int> ds3 = new List<int>() {1,2,3,4,5,7};
            Console.WriteLine("Danh sách 3 là: ");
            foreach (int i in ds3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Add thêm phần tử vào cuối list
            List<int> ds4 = new List<int>() { 1, 5, 7 };
            ds4.Add(100);
            ds4.Add(200);
            Console.WriteLine("Danh sách 4 sau khi add là: ");
            foreach (int i in ds4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Remove(object) :Xóa phần tử tìm thấy lần đầu tiên
            List<int> ds5 = new List<int> { 1, 5, 7, 5, 4, 8, 9 };
            ds5.Remove(5);
            Console.WriteLine("Danh sách 5 sau khi xóa là: ");
            foreach (int i in ds5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Count Đếm số phần tử
            List<int> ds6 = new List<int> { 1, 5, 7, 5, 4, 8, 9 };
            Console.WriteLine("Số phần tử trong danh sách 6: " + ds6.Count);

            //Clear() Xóa toàn bộ phần tử
            List<int> ds7 = new List<int> { 1, 5, 7, 5, 4, 8, 9 };
            ds7.Clear();

            //ds8.AddRange(ds9) thêm toàn bộ ds9 vào cuối ds8
            List<int> ds8 = new List<int> { 1, 8, 9 };
            List<int> ds9 = new List<int> { 1, 5 };
            ds8.AddRange(ds9);
            Console.WriteLine("Danh sách 8 là: ");
            foreach (int i in ds8)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // bool =<ds> Contains(<value>)   Kiểm tra có tồn tại value trong ds không trả về true hoặc false
            List<int> ds10 = new List<int> { 1, 8, 9, 100 };
            bool kq = ds10.Contains(15);
            Console.WriteLine(kq);

            //GetRange(int index, int count)   Lấy ra danh sách con
            List<int> ds11 = new List<int> { 13, 18, 29, 100, 1, 23 };
            List<int> ds12 = ds11.GetRange(2, 3);
            Console.WriteLine("Danh sách 12 là: ");
            foreach (int i in ds12)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //int IndexOf(<value>)  trả về vị trí index giá trị value nếu không có thì =-1
            //chỉ giá trị đầu tiên
            List<int> ds13 = new List<int> { 13, 18, 29, 100, 1, 23, 100 };
            int checkIndex = ds13.IndexOf(100);
            Console.WriteLine("Index của số cần tìm trong danh sách 13 là: " + checkIndex);

            //Insert(int index,value) ; chèn thêm value tại vị trí được chỉ định
            List<int> ds14 = new List<int> { 13, 23, 100, 1, 23, 100 };
            ds14.Insert(1, 1000);
            Console.WriteLine("Danh sách 14 là: ");
            foreach (int i in ds14)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //InsertRange(index,<danh sách chèn thêm>)  chèn danh sách vào vị trí index
            List<int> ds15 = new List<int> { 13, 3, 100 };
            List<int> ds16 = new List<int> { 13, 22 };
            ds15.InsertRange(2, ds16);
            Console.WriteLine("Danh sách 15 là: ");
            foreach (int i in ds15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //RemoveAt(int index);  Xóa phần tử tại vị trí chỉ định
            List<int> ds17 = new List<int> { 2, 31, 78, 9, 13, 3, 100 };
            ds17.RemoveAt(5);
            Console.WriteLine("Danh sách 17 là: ");
            foreach (int i in ds17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //RemoveRange(int index, int count)  Xóa danh sách phần từ vị trí
            List<int> ds18 = new List<int> { 2, 31, 23, 76, 9, 32, 13, 3, 100 };
            ds18.RemoveRange(3,6);
            Console.WriteLine("Danh sách 18 là: ");
            foreach (int i in ds18)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // <ds>.Reverse(); Đảo ngược danh sách
            List<int> ds19 = new List<int> { 2, 31, 23, 76, 9, 32, 13, 3, 100 };
            ds19.Reverse();
            Console.WriteLine("Danh sách 19 là: ");
            foreach (int i in ds19)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //<ds>.Sort(): Xắp sếp tăng dần
            List<int> ds20 = new List<int> { 2, 31, 23, 76, 9, 32, 13, 3, 100 };
            ds20.Sort();
            Console.WriteLine("Danh sách 20 là: ");
            foreach (int i in ds20)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //BinarySreach: Phải sắp xếp trước mới tìm kiếm chính xác -không có thì là giá trị âm
            int kq2 = ds20.BinarySearch(23);
            Console.WriteLine(kq2);

            //Max,Min
            int kq3 = ds20.Max();
            Console.WriteLine("Gía trị max la: " +kq3);
            Console.WriteLine("Gía trị min là: " + ds20.Min());
            Console.ReadKey();
        }
    }
}
