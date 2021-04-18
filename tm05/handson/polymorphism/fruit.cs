using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    class fruit
    {
       public  String name, taste;
       public decimal size;
        public void eat()
        {
            Console.WriteLine("In class fruit");
        }
    }
   class apple:fruit
    {
        public void eat()
        {
            String name = "apple";
            String taste = "sweet";
            Console.WriteLine("Name: " + name + "\n" + "Taste: " + taste);
        }
        
    }
    class orange:fruit
    {
        public void eat()
        {
            String name = "orange";
            String taste = "sour";
            Console.WriteLine("Name: " + name + "\n" + "Taste: " + taste);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            fruit f = new fruit();
            apple a = new apple();
            orange o = new orange();
            f.eat();
            a.eat();
            o.eat();
        }
    }
}

