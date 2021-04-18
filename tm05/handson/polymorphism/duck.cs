using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    class SuperDuck
    {
        public virtual void Eat()
        {

        }
    }
    class MyDuck : SuperDuck
    {
        public override void Eat()
        {
            Console.WriteLine(" I am eating food...");
        }
    }
    class ToyDuck : SuperDuck
    {
        public override void Eat()
        {
            Console.WriteLine(" My food is electrons...");
        }
    }
    class Duck
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Press 1 for Feeding your Duck");
            Console.WriteLine("Press 2 for feeding the Toy Duck");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        MyDuck md = new MyDuck();
                        md.Eat();
                        break;
                    }
                case 2:
                    {
                        ToyDuck td = new ToyDuck();
                        td.Eat();
                        break;
                    }
            }
        }



    }
}








