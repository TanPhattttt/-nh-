using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyentapTutorb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int chon;
            QLNV service = new QLNV();
            do
            {
                Console.WriteLine("------MENU------");
                Console.WriteLine("1. Nhập nhân viên");
                Console.WriteLine("2. Xuat ra thông tin nhân viên");
                Console.WriteLine("3. Xuất các danh sách nhân viên có doanh thu theo người nhập");
                Console.WriteLine("4. Tìm nhân viên theo mã");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("------------------------");
                Console.WriteLine("Mời nhập lựa chọn của bạn: ");

                chon = Convert.ToInt32(Console.ReadLine());

                switch (chon)
                {
                    case 0:
                        Console.WriteLine("Bạn đã chọn thoát");
                        break;
                    case 1:
                        Console.WriteLine("Bạn đã chọn nhập nhân viên");
                        service.nhap();
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn xuất nhân viên");
                        service.Xuat();
                        break;
                    case 3:
                        Console.WriteLine("Bạn chọn Xuất các danh sách nhân viên có doanh thu theo người nhập");
                        break;
                    case 4:
                        Console.WriteLine("Bạn chọn tìm nhân viên theo mã");
                        break;
                    default:
                        Console.WriteLine("KHông có lựa chọn hợp lệ mời nhập lại");
                        break;
                }
            } while (chon != 0);
        }
    }
}
