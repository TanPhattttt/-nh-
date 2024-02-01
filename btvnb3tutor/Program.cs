using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace btvnb3tutor
{
    internal class Program
    {
        static bool IsZigzag(int[] array)
        {
            // Kiểm tra xem mảng có ít nhất hai phần tử hay không
            if (array.Length < 2)
            {
                return false;
            }

            // Khởi tạo biến
            int previous = array[0];
            bool increasing = true;

            // Duyệt qua mảng
            for (int i = 1; i < array.Length; i++)
            {
                // Kiểm tra xem hướng tăng giảm
                if (increasing)
                {
                    if (array[i] <= previous)
                    {
                        return false;
                    }
                }
                else
                {
                    if (array[i] >= previous)
                    {
                        return false;
                    }
                }

                // Cập nhật hướng tăng giảm
                increasing = !increasing;
                previous = array[i];
            }

            return true;
        }


        static void Main(string[] args)
        {
            int[] array = { 2, 5, 3, 6, 4, 8 };

            // Kiểm tra xem mảng có phải là mảng zigzag hay không
            bool isZigzag = IsZigzag(array);

            // In kết quả
            Console.WriteLine("Mảng có phải là mảng zigzag không? {0}", isZigzag);
        }
    }
}
