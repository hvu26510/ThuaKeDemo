using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract internal class Hinh
    {
        protected double cv;
        protected double dienTich;

        public abstract void TinhDienTich();
        public abstract void TinhChuVi();
    }

    class HinhVuong : Hinh
    {
        private double canh;

        public void setCanh(double c)
        {
            this.canh = c;
        }
       
        public double getDT()
        {
            return this.dienTich;
        }

        public double getCV()
        {
            return (double)this.cv;
        }
        public override void TinhDienTich()
        {
            this.dienTich = canh * canh;
        }

        public override void TinhChuVi()
        {
            this.cv = canh * 4;
        }
    }

}
