using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onta_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot so la: "); 
            int number = int.Parse(Console.ReadLine());
            bool Isprime = true;
            if(number < 2)
            {
                Console.WriteLine($" {number} is not prime number");
            }
            for( int i = 2; i <= 2; i++)
            {
                if( number % i == 0 )
                {
                    Isprime = false;
                    break;
                }
            }
            if(Isprime )
            {
                Console.WriteLine($"{number} la mot so nguyen to");
            }else
            {
                Console.WriteLine($"{number} khong phai la mot so nguyen to");
            }
            

            
        }
    }
}
