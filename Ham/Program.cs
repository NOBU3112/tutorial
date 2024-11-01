using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ham
{
    internal class Program
    {
        //Chú thích hàm dùng ///
        /// <summary>
        /// Hàm này là để tính tổng
        /// </summary>
        /// <param name="x">Nhập x nguyên</param>
        /// <param name="y">Nhập y nguyên</param>
        /// <param name="z">Nhập z nguyên</param>
        /// <returns>nó return tổng ba số</returns>
        //Khai báo hàm     Hàm thủ tục(ko trả về giá trị) dùng void thay kiểu dữ liệu
        //Có trả về
        static int Tong(int x,int y,int z)
        {
            return x+y+z;
        }
        //giai thừa
        static int TinhGiaiThua(int n)
        {
            int gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt *=i;
            }
            return gt;
        }

        //Không chả về
        static void Xinchao(string m)
        {
            if(m =="nam")
                Console.WriteLine("Xin chào mình là boy");
            if (m == "nu")
                Console.WriteLine("Xin chào mình là girl");
        }

        //truyền tham trị không thay đổi giá trị biến sau khi gọi hàm
        static void Thamtri(int a) 
        {
            a = a + 1;
            Console.WriteLine("Gía trị a trong hàm là: " + a);
        }

        //ref: Truyền tham chiếu: có thay giá trị của biến sau khi gọi hàm
        static void ThamchieuRef(ref int b)
        {
            b++;
            Console.WriteLine("b trong hàm là: " + b);
        }

        //out: Truyền tham chiếu: có thay giá trị của biến sau khi gọi hàm
        static void ThamchieuOut(out int c)
        {
            c = 5;
            Console.WriteLine("c trong hàm là: " + c);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int kq=Tong(5,3,7);
            Console.WriteLine("kq= "+kq);

            //xuất giai thừa
            int k = 3;
            int kq2 = TinhGiaiThua(k);
            Console.WriteLine("kq2= " + kq2);

            Xinchao("nam"); // không gắn biến đc
            Xinchao("nu");

            int kq3 = Tong(7, 8, 9);

            //Truyền tham trị 
            int a = 1;
            Console.WriteLine("a trước gọi hàm là: " + a);
            Thamtri(a);
            Console.WriteLine("a sau khi gọi hàm là: " + a);

            //Truyền tham chiếu ref:ref phải khởi tạo giá trị cho biến trước khi thoát khỏi hàm
            int b = 2; //chỉ int b; sẽ báo lỗi
            Console.WriteLine("b trước gọi hàm là: " + b);
            ThamchieuRef(ref b);
            Console.WriteLine("b sau khi gọi hàm là: " + b);

            //Truyền tham chiếu out:out phải gán giá trị cho biến trc khi thoát khỏi hàm
            int c;
            ThamchieuOut(out c);
            Console.WriteLine("c sau khi gọi hàm là: " + b);
            Console.ReadKey();
        }
    }
}
