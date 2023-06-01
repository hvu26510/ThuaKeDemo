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
            //NhanVien nv1 = new NhanVien("Nguyen van A", "Ha Noi", "anv@gmail.com", "0123456789", "Phu Ho - Cap Cao");

            //nv1.Show();

            KeToan kt1 = new KeToan("Nguyen van A", "Ha Noi", "anv@gmail.com", "0123456789", "Phu Ho - Cap Cao", 15000000);

            kt1.Show();

            Console.ReadLine();
        }
    }
}
