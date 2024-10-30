using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai báo chuỗi
            Console.OutputEncoding = Encoding.UTF8;
            string chuoi = "Gà lại lập trình";
            Console.WriteLine("Chuỗi bạn vừa nhập là: " + chuoi);
            Console.WriteLine();

            //khai báo nguyên văn @
            /* Một số ký tự đặc biệt:
              \\ -> \
              \' -> '
              \" -> "
              \n -> Xuống dòng mới
              \t -> Tab ngang */
            string chuoi2 = @"D\Users"; //sẽ bị lỗi nếu không có @ do \
            string chuoi3 = "Có người nói rằng : \" abc \""; //sẽ bị lỗi nếu chỉ có " mà không phải \"
            string chuoi4 = "Có người nói rằng :\t \" abc \"";
            Console.WriteLine(chuoi2);
            Console.WriteLine(chuoi3);
            Console.WriteLine(chuoi4);
            Console.WriteLine();

            //Chuyển đổi sang chuỗi
            int i = 1234;
            string chuoi5 = i.ToString(); //Cách 1
            string chuoi6 = i + ""; //Cách 2
            string chuoi7 = Convert.ToString(i); //Cách 3
            Console.WriteLine(chuoi5);
            Console.WriteLine(chuoi6);
            Console.WriteLine(chuoi7);
            Console.WriteLine();

            //Tách chuỗi thành các ký tự vào mảng
            string chuoi8 = "Xin chào";
            char[] lst = chuoi8.ToCharArray();
            Console.WriteLine(lst);
            Console.WriteLine(lst.GetType().ToString());
            Console.WriteLine();


            //Length Trả về độ dài chuỗi
            string chuoi9 = "Test haha";
            int j = chuoi9.Length;
            Console.WriteLine(j);
            //in ra ký tự, ký tự bắt đầu với 0
            Console.WriteLine("Ký tự thứ hai của chuỗi là: " + chuoi9[1]);
            Console.WriteLine("Ký tự cuối của chuỗi là: " + chuoi9[j-1]);
            Console.WriteLine();

            //Ví dụ
            string chuoi10 = "Tôi là number 1";
            char[] lst2 = chuoi10.ToCharArray();
            int demSo = 0;
            int demChuThuong = 0;
            int demInHoa = 0;
            int demKhoangTrang = 0;
            foreach(char c in lst2)
            {
                // Console.WriteLine(c);
                if (char.IsDigit(c))
                    demSo++;
                else if (char.IsLower(c))
                    demChuThuong++;
                else if (char.IsUpper(c))
                    demInHoa++;
                else if (char.IsWhiteSpace(c))
                    demKhoangTrang++;
            }
            Console.WriteLine("Chuỗi có {0} ký tự viết thường", demChuThuong);
            Console.WriteLine("Chuỗi có {0} ký tự viết hoa", demInHoa);
            Console.WriteLine("Chuỗi có {0} ký tự số", demSo);
            Console.WriteLine("Chuỗi có {0} ký tự khoảng trắng", demKhoangTrang);
            Console.WriteLine();

            //So sánh chuỗi
            string chuoi11 = "123456a";
            string chuoi12 = "123456m";
            int sosanh = chuoi11.CompareTo(chuoi12);
            Console.WriteLine(sosanh);
            Console.WriteLine();

            //Kiểm tra chuỗi con
            string chuoi13 = "abc";
            string chuoi14 = "adsadsadsadaa bc123";
            bool l = chuoi14.Contains(chuoi13);
            Console.WriteLine(l);
            Console.WriteLine();

            //Copyto
            string chuoi15 = "123456";
            char[] lst3 = new char[6]; //Tạo ra 1 mảng có độ dài = 6
            lst3[0] = 'a';
            lst3[1] = 'b';
            Console.WriteLine(lst3);
            chuoi15.CopyTo(1, lst3, 1, 4); //copy(từ index nào , vào đâu , vào index nào , copy bao nhiêu ký tự) , sễ xóa luôn ký tụ bị copy lên
            Console.WriteLine(lst3);
            Console.WriteLine();

            //Hàm bool Endswith(string Value)
            string chuoi16 = "ditimtinhyeu.mp3";
            bool kt = chuoi16.EndsWith(".mp3");//xét có kết thúc vói
            Console.WriteLine(kt);
            Console.WriteLine();

            //Gán chuỗi theo string.Format
            int n = 14;
            string chuoi17 = string.Format("n={0} và căn bậc 2 của n là {1}", n, Math.Sqrt(n)); //Gắn vào biến để có thể dùng lại được
            Console.WriteLine(chuoi17);
            Console.WriteLine("n={0} và căn bậc 2 của n là {1}", n, Math.Sqrt(n));
            Console.WriteLine();

            //bool Equals
            string chuoi18 = "HAHA";
            string chuoi19 = "HAHA";
            bool kt2 = chuoi18.Equals(chuoi19);
            Console.WriteLine(kt2);
            Console.WriteLine();

            //Chèn thêm vào chuỗi string.Insert(<vị trí start_index chuỗi bắt đầu>,<chuỗi cần chèn>)
            string chuoi20 = "123";
            string chuoi21 = "OBAMA";
            chuoi20 = chuoi20.Insert(2, chuoi21);
            Console.WriteLine(chuoi20);
            Console.WriteLine();

            //IndexOf kiểm tra vị trí xuất hiện lần đầu tiên(index)
            string chuoi22 = "123asssa";
            int kq = chuoi22.IndexOf('a');
            Console.WriteLine(kq);
            Console.WriteLine();

            //LastIndexOF kiểm tra vị trí xuất hiên cuối cùng(inddex)
            int kq2 = chuoi22.LastIndexOf('a');
            Console.WriteLine(kq2);
            Console.WriteLine();

            //Remove(index,count)
            string chuoi23 = "123456";
            Console.WriteLine(chuoi23);
            chuoi23 = chuoi23.Remove(1, 2);
            Console.WriteLine(chuoi23);
            Console.WriteLine();

            //Replace("str cũ","str mới")
            string chuoi24 = "123445674489";
            Console.WriteLine(chuoi24);
            chuoi24 = chuoi24.Replace("44", "aaa");
            Console.WriteLine(chuoi24);
            Console.WriteLine();

            //bool StartsWith  kiểm tra chuỗi có bắt đầu với chuỗi con không
            string chuoi25 = "ditimtinhyeu.mp3";
            bool kt3 = chuoi25.StartsWith("ditim");
            Console.WriteLine(kt3);
            Console.WriteLine();

            //Substring(index,count)  Trích lọc chuỗi con từ chuỗi ban đầu
            string chuoi26 = "123456";
            string chuoi27 = chuoi26.Substring(2,3);
            Console.WriteLine(chuoi27);
            Console.WriteLine();

            //ToLower và ToUpper
            string chuoi28 = "Con đi học về muộn HAHAHA";
            Console.WriteLine(chuoi28);
            chuoi28 = chuoi28.ToLower();//ép sang thường
            Console.WriteLine(chuoi28);
            chuoi28 = chuoi28.ToUpper();//ép sang in hoa
            Console.WriteLine(chuoi28);
            Console.WriteLine();

            //Trim() Xóa toàn bộ khoảng trắng từ đầu và đuôi
            string chuoi29 = "       12312      ";
            chuoi29 = chuoi29.Trim();
            Console.WriteLine(chuoi29);

            //TrimEnd() Xóa khoảng trắng ở cuối TrimStart()  Xóa toàn bộ khoảng trắng ở đầu
            string chuoi30 = "         23432434 43244 4         ";
            chuoi30 = chuoi30.TrimEnd();
            Console.WriteLine(chuoi30);
            chuoi30 = chuoi30.TrimStart();
            Console.WriteLine(chuoi30);
            Console.WriteLine();

            //Split Tách chuỗi trả về mảng
            string chuoi31 = @"D\DASDSA\aaD.mp3";
            string[] lst4 = chuoi31.Split('\\');
            Console.WriteLine(lst4[0]);
            Console.WriteLine(lst4[1]);
            Console.WriteLine(lst4[2]);
            Console.WriteLine();

            //Joint string nối các phần tử của 1 list thành chuỗi
            string chuoi32 = string.Join("++", lst4);
            Console.WriteLine(chuoi32);
            Console.ReadKey();
        }
    }
}
