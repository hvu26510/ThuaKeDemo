using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList listSV = new ArrayList();

            // tạo đối tượng sv1 kiểu SinhVien
            SinhVien sv1 = new SinhVien();
            sv1.Nhap();

            //thêm đối tượng vào listSV
            listSV.Add(sv1);

            // tạo đối tượng sv2 kiểu SinhVien
            SinhVien sv2 = new SinhVien();
            sv2.Nhap();

            //thêm đối tượng vào listSV
            listSV.Add(sv2);



            Console.Clear();

            //xoa sv1 khoi listSV

            listSV.Remove(sv1);

            foreach (SinhVien i in listSV)
            {
                i.Show();
            }

            Console.ReadLine();



        }
    }
}
