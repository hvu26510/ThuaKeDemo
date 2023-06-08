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
            addDataDemo(ref listSV);

            //var listByDiem = listSV.Cast<SinhVien>().Where(sv => sv.getDiem() >= 5 && sv.getDiem() <= 7);

            //foreach(SinhVien i in listByDiem)
            //{
            //    i.Show();
            //}



            Print5Highest(listSV);
            //foreach(SinhVien sv in list)
            //{
            //    sv.Show();
            //}

            Console.ReadLine();

        }
        static void addDataDemo(ref ArrayList list)
        {
            SinhVien sv1 = new SinhVien(1, "Nguyen Van A", "anv@email.com", 10);
            SinhVien sv2 = new SinhVien(2, "Nguyen Van hai", "hainv@email.com", 5);
            SinhVien sv3 = new SinhVien(3, "Nguyen Van ba", "banv@email.com", 7);
            SinhVien sv4 = new SinhVien(4, "Nguyen Van bon", "bonnv@email.com", 8);
            SinhVien sv5 = new SinhVien(5, "Nguyen Van nam", "namnv@email.com", 1);
            SinhVien sv6 = new SinhVien(6, "Nguyen Van sau", "saunv@email.com", 0);

            list.Add(sv1);
            list.Add(sv2);
            list.Add(sv3);
            list.Add(sv4);
            list.Add(sv5);
            list.Add(sv6);

        }

        static SinhVien FindByMaSV(ArrayList list, int masv)
        {
            foreach (SinhVien sv in list)
            {
                if(sv.getMASV() == masv)
                {
                    return sv;
                }
            }
            return null;
        }

        static ArrayList FindByDiem(ArrayList list, double min, double max)
        {
            ArrayList listOut = new ArrayList();
            foreach (SinhVien sv in list)
            {
                if (sv.getDiem() >= min && sv.getDiem()<= max)
                {
                    listOut.Add(sv);
                }
            }
            return listOut;
        }

        //sap xep tang dan, tra ve List<SinhVien> co diem tang dan
        static List<SinhVien> Sort(ArrayList list)
        {
            List<SinhVien> listOutPut = list.Cast<SinhVien>().ToList();
            listOutPut.Sort((sv1, sv2) => sv2.getDiem().CompareTo(sv1.getDiem()));
            return listOutPut;

        }
    
        static void Print5Highest(ArrayList listSV)
        {
            List<SinhVien> list = listSV.Cast<SinhVien>().ToList();
            list.Sort((sv1, sv2) => sv2.getDiem().CompareTo(sv1.getDiem()));
            for (int i =0; i<list.Count(); i++)
            {
                if (i < 5)
                {
                    list[i].Show();
                }
                else
                {
                    break;
                }
               
            }
        }

    
    }
}
