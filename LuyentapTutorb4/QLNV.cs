using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LuyentapTutorb4
{
    internal class QLNV
    {
        List<Nhanvien> lstnhanvien;
        string input;
        
        public void nhap()
        {
            do 
            {
                Nhanvien nhanvien = new Nhanvien();
                Console.WriteLine("Nhập ID nhân viên: ");
                nhanvien.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập tên nhân viên: ");
                nhanvien.Name = Console.ReadLine();
                Console.WriteLine("Doanh thu của nhân viên: ");
                nhanvien.Doanhthu = Convert.ToDouble(Console.ReadLine());
                lstnhanvien.Add(nhanvien);
                Console.WriteLine("Bạn có muốn nhập tiếp hay không: (Y/N)");
                input = Console.ReadLine();
            }while (input == "Y" || input == "y");
        }

        //Kiểm tra  listNhanvien có phần tử hay không
        private bool CheckCount()
        {
            if (lstnhanvien.Count == 0)
            {
                return true;
            }
            return false;
        }
        public void Xuat()
        {
            if (CheckCount())
            {
                Console.WriteLine("Không có danh sách ");
                return;
            }
            foreach ( var item in lstnhanvien )
            {
                item.Inthongtin();
            }
        }
    }
}
