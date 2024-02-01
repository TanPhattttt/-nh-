using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNb4_TUTOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int chon;
            QLnguoiCT service = new QLnguoiCT();
            do
            {
                Console.WriteLine("----Menu----");
                Console.WriteLine("1. Nhập đối tượng.");
                Console.WriteLine("2. Xuất đối tượng.");
                Console.WriteLine("3. Xuất danh sách người cao tuổi < 70 tuổi");
                Console.WriteLine("4. Tìm người cao tuổi theo mã");
                Console.WriteLine("5. Kế thừa");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("------------");
                Console.WriteLine("Mời chọn chương trình");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Bạn đã chọn nhập người cao tuổi");
                        service.Nhap();
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn xuất người cao tuổi");
                        service.Xuat();
                        break;
                    case 3:
                        Console.WriteLine("Danh sách người cao tuổi < 70");
                        service.XuatDSNhoHon70();
                        break;
                    case 4:
                        Console.WriteLine("Tìm mã người cao tuổi");
                        service.TimTheoMa();
                        service.TimTheoMaLinq();
                        break;
                    case 5:
                        service.KeThua();
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Chọn sai chương trình");
                        break;
                }
            } while (chon != 0);
        }
    }
}
