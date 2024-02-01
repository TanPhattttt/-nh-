using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hàm
{
    internal class Program
    {
        static void TinhToan()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            float c = a + b;
            Console.WriteLine(c);
        }
        static void Tinhtru(int a, int b)
        {
            Console.WriteLine($"{a} tru di {b} bang: {a - b}");
        }
        static string TuThuat()
        {
            Console.WriteLine("Nhap thong tin ca nhan");
            Console.WriteLine("Nhap ten: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            int namsinh = int.Parse(Console.ReadLine());
            return $"Thong tin ca nhan: \n" +
                $"Ten: {ten}\n Tuoi: {DateTime.Now.Year - namsinh}\n Nam sinh: {namsinh}";
        }
        static int SumOfArray(int size)
        {
            int[] arr = new int[size];
            int sum = 0;
            Console.WriteLine("Nhap mang: ");
            int i = 0;
            do
            {
                Console.WriteLine($"Nhap phan tu thu {i +1}:  ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
                i++;
            }while (i < size);
            return sum;
        }
        static int Tinh(long size)
        {
            int[] arr = new int[size];
            Console.WriteLine("Nhap mang: ");
            int cong = 0;
            int tru = 0;
            int nhan = 0;
            double chia = 0;
            int i = 0;
            do
            {
                Console.WriteLine($"Nhap mang lien tuc: {i + 1}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Tinh tong: {i++}");
                Console.WriteLine($"Tinh tru: {i--}");
                Console.WriteLine($"Tinh nhan: {i}");
                Console.WriteLine($"Tinh chia: {i}");
                cong += arr[i];
                tru -= arr[i];
                nhan *= arr[i];
                chia /= arr[i];
                i++;
            } while (i < size);
            return cong;
        }
        static void Main(string[] args)
        {
            //TinhToan();
            // Tinhtru(1,2);
            // Console.WriteLine(TuThuat());
            //Console.WriteLine("Tong cac phan tu cua mang la: " + SumOfArray(5));
            Console.WriteLine("Cong tru nhan chia la: " + Tinh(2));
        }
    }
}
