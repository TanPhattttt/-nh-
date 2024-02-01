using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tìm chu vi va dien tich hinh tron

            Console.WriteLine("Nhap vao duong kinh hinh tron la: ");
            double D = double.Parse(Console.ReadLine());
            double C = Math.PI  * D;
            double S = Math.PI * D * D;
            Console.WriteLine("Chu vi hinh tron la: {0}",C);
            Console.WriteLine("Dien tich hinh tron la: {0}",S);

            Console.ReadKey();
        }
    }
}
