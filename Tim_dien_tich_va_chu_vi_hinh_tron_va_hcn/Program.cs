using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim_dien_tich_va_chu_vi_hinh_tron_va_hcn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dk = true;
            float r, cv, dt, pi = 3.14f, cd, cr;
            String hinh, yn;
            do
            {
                Console.WriteLine("Ban muon tinh chu vi, dien tich cua hinh tron hay hinh chu nhat (ht hay hcn): ");
                hinh = Console.ReadLine();
                if (hinh == "ht")
                {
                    Console.WriteLine("Nhap vao ban kinh: ");
                    r = float.Parse(Console.ReadLine());
                    cv = 2 * r * pi;
                    dt = pi * r * r;
                    Console.WriteLine("Chu vi hinh tron = " + cv);
                    Console.WriteLine("Dien tich hinh tron = " + dt);
                }
                else if (hinh == "hcn")
                {
                    Console.WriteLine("Nhap vao chieu dai:");
                    cd = float.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap vao chieu rong:");
                    cr = float.Parse(Console.ReadLine());
                    cv = (cd + cr) * 2;
                    dt = cd * cr;
                    Console.WriteLine("Chu vi hinh chu nhat = " + cv);
                    Console.WriteLine("Dien tich hinh chu nhat = " + dt);
                }
                else
                    Console.WriteLine("Nhap ht hoac hcn");
                do
                {
                    Console.WriteLine("Ban co muon tiep tuc y/n:");
                    yn = Console.ReadLine();
                    if (yn == "n")
                    {
                        dk = false;
                    }
                } while (yn != "y" && yn != "n");
            } while (dk != false);
        }
    }
}
