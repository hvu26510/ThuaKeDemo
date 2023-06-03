using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract internal class SinhVienPoly
    {
        protected string hoTen;
        protected string Nganh;

        protected SinhVienPoly(string hoTen, string nganh)
        {
            this.hoTen = hoTen;
            Nganh = nganh;
        }

        public abstract double getDiem();
        public string getHocLuc()
        {
            if (this.getDiem() < 5)
            {
                return "Yeu";
            }
            else if (this.getDiem() < 6.5)
            {
                return "TB";
            }
            else if (this.getDiem() < 7.5)
            {
                return "Kha";
            }
            else if (this.getDiem() < 9)
            {
                return "gioi";
            }
            else
            {
                return "Xuat sac";
            }
        }

        public void xuat()
        {
            Console.WriteLine("Ten :" + this.hoTen);
            Console.WriteLine("Nganh :" + this.Nganh);
            Console.WriteLine("Diem :" + this.getDiem());
            Console.WriteLine("Hoc luc :" + this.getHocLuc());
        }

    }

    class SinhVienIT : SinhVienPoly
    {
        private double diemJava;
        private double diemCSS;
        private double diemHTML;

        public SinhVienIT(string hoTen, string nganh, double diemJava, double diemCSS, double diemHTML)
            : base(hoTen, nganh)
        {
            this.diemJava = diemJava;
            this.diemCSS = diemCSS;
            this.diemHTML = diemHTML;
        }

        public override double getDiem()
        {
            return (this.diemJava * 2 + this.diemHTML + this.diemCSS) / 4;
        }
    }

    class SinhVienBiz : SinhVienPoly
    {
        private double diemMKT;
        private double diemSale;

        public SinhVienBiz(string hoTen, string nganh, double diemMKT, double diemSale)
            : base(hoTen, nganh)
        {
            this.diemMKT = diemMKT;
            this.diemSale = diemSale;
        }

        public override double getDiem()
        {
            return (this.diemMKT * 2 + this.diemSale) / 3;
        }
    }
}
