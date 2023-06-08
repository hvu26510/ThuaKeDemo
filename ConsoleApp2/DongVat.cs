using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract internal class DongVat
    {
        public abstract void Eat();
    }

    class Bird : DongVat
    {

        public override void Eat()
        {
            Console.WriteLine("Chim an bang cach: Mo mo mo");
        }
    }

    class Cat : DongVat
    {
        public override void Eat()
        {
            Console.WriteLine("Vua an vua keu: meo meo meo");
        }
    }
}
