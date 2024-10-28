using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinh_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float chieuCao, canNang;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chiều cao (m): ");
            chieuCao = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng (kg): ");
            canNang = float.Parse(Console.ReadLine());

            //tinh BMI
            double BMI = canNang / (Math.Pow(2, chieuCao));// = chieu cao binh phuong
            //Console.WriteLine("BMI của bạn là: " + BMI);
            Console.WriteLine("BMI của bạn là: " + Math.Round(BMI,2));//lam tron so hai chu so sau thap phan
            if (BMI < 15)
                Console.WriteLine("Thân hình quá gầy");
            else if (BMI < 16)
                Console.WriteLine("Thân hình gầy");
            else if (BMI < 18.5)
                Console.WriteLine("Thân hình hơi gầy");
            else if (BMI < 25)
                Console.WriteLine("Thân hình bình thường");
            else if (BMI < 30)
                Console.WriteLine("Thân hình hơi béo");
            else if (BMI < 35)
                Console.WriteLine("Thân hình béo");
            else
                Console.WriteLine("Thân hình quá béo");
            Console.ReadKey();
        }
    }
}
