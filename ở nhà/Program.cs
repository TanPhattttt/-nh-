using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ở_nhà
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //for (; i < 11; i++)
            //{
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine("Gia tri sau vong for la: "+i);
            //while (i < 11)
            //{
            //    Console.WriteLine(i+" ");
            //    i++;
            //}


            //Dùng vòng lặp for để kiểm tra số nguyên tố

            //Số nguyên tố là số nguyên dương chỉ có 2 ước nguyên dương là 1 và chính nó

            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;
                                
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Số là số nguyên tố");
            }
            else
            {
                Console.WriteLine("Số không phải là số nguyên tố");
            }

            Console.ReadKey(); ;

            //Sử dụng do -while để viết chương trình yếu cầu người dùng cho đền khi nhập một số
            //chính phương thì số đó ra và dừng lại
            //(nâng cao) Nhập 1 số thực bất kì đến khi số chính phương thì dừng lại

            //do
            //{
            //    Console.WriteLine("Please enter a number: ");
            //    int num = int.Parse(Console.ReadLine());
            //    int a = (int)Math.Sqrt(num); // Tính nguyen cua căn bậc hai của số vừa nhập
            //    if (a * a == num)
            //    {
            //        Console.WriteLine($"{num} is a square number!");
            //        break;
            //    }
            //} while (true);
        }
    }
}
