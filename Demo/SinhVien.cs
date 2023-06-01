using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SinhVien
    {
        private string name;
        private double diem;
        private string email;

        public string HocLuc()
        {
            if(this.diem < 5)
            {
                return "Yeu";
            }else if (this.diem < 6.5)
            {
                return "TB";
            }else if (this.diem < 7.5)
            {
                return "Kha";
            }else if(this.diem < 9)
            {
                return "gioi";
            }else
            {
                return "Xuat sac";
            }
        }
        public void Show()
        {
            Console.WriteLine("Ten:"+ this.name);
            Console.WriteLine("Diem:" + this.diem);
            Console.WriteLine("email:" + this.email);
            Console.WriteLine("Hoc luc:" + this.HocLuc());
        }

        public void Nhap()
        {
            Console.Write("Ten:" );
            this.name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Diem:");
            this.diem = double.Parse( Console.ReadLine() );
            Console.WriteLine();
            Console.Write("email:" + this.email);
            this.email = Console.ReadLine();
        }


    }
}
