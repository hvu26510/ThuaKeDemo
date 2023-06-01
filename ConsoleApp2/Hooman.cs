using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Hooman
    {
        protected string Name;
        protected string Address;
        protected string Email;
        protected string PhoneNumber;

        public Hooman(string name, string address, string email, string phoneNumber)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }


        public virtual void Show()
        {
            Console.WriteLine("Ten: " + this.Name);
            Console.WriteLine("Dia Chi: " + this.Address);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("SDT: " + this.PhoneNumber);
        }
    }

    class NhanVien : Hooman
    {
        protected string BangCap;

        public NhanVien(string name, string address, string email, string phoneNumber, string BangCap) : 
            base(name, address, email, phoneNumber)
        {
            this.BangCap = BangCap;
        }


        public override void Show()
        {
            Console.WriteLine("Ten: " + this.Name);
            Console.WriteLine("Dia Chi: " + this.Address);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("SDT: " + this.PhoneNumber);
            Console.WriteLine("Bang Cap: " + this.BangCap);
           

        }

    }

    class KeToan : NhanVien
    {
        private int Luong;

        public KeToan(string name, string address, string email, string phoneNumber, string BangCap, int Luong) : 
            base(name, address, email, phoneNumber, BangCap)
        {
            this.Luong = Luong;
        }

        public override void Show()
        {
            Console.WriteLine("Ten: " + this.Name);
            Console.WriteLine("Dia Chi: " + this.Address);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("SDT: " + this.PhoneNumber);
            Console.WriteLine("Bang Cap: " + this.BangCap);
            Console.WriteLine("Luong: " + this.Luong);
        }
    }
}
