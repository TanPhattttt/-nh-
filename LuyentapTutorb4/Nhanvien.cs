using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyentapTutorb4
{
    internal class Nhanvien
    {
        int id;
        string name;
        double doanhthu;

        public Nhanvien()
        {
            
        }

        public Nhanvien(int id, string name, double doanhthu)
        {
            this.Id = id;
            this.Name = name;
            this.Doanhthu = doanhthu;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Doanhthu { get => doanhthu; set => doanhthu = value; }

        public virtual void Inthongtin()
        {
            Console.WriteLine($"{Id} | {name} | { doanhthu} ");
        }

    }
}
