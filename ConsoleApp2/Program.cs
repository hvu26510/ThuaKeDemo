using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            HinhVuong hv = new HinhVuong();

            hv.setCanh(3);
            hv.TinhDienTich();
            hv.TinhChuVi();

            Console.WriteLine("Dien tich: "+ hv.getDT());
            Console.WriteLine("Chu vi : " + hv.getCV());


            Console.ReadLine();
        }
    }
}
