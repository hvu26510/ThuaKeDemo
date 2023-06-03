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

            SinhVienIT svIT = new SinhVienIT("Nguyen Van A", "IT", 8 ,9, 11);

            svIT.xuat();

            SinhVienBiz svBiz = new SinhVienBiz("Nguyen Van A", "Biz", 8, 9);
            svBiz.xuat();

            Console.ReadLine();
        }
    }
}
