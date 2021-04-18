using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
   class student
    {
        String name;
        int mark1,mark2,mark3;
        public student()
        {

        }
        public student(String name, int mark1, int mark2,int mark3)
        {
            this.name = name;
            this.mark1 = mark1;
            this.mark2= mark2;
            this.mark3 = mark3;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Mark1
        {
            get { return mark1; }
            set { mark1 = value; }
        }
        public int Mark2
        {
            get { return mark2; }
            set { mark2 = value; }
        }
        public int Mark3
        {
            get { return mark3; }
            set { mark3 = value; }
        }
        public void add()
        {
            List<student> rec = new List<student>();
            Console.WriteLine("enter name of the student");
            String name = Console.ReadLine();
            Console.WriteLine("enter marks one by one");
            try
            {
                int mark1 = Convert.ToInt32(Console.ReadLine());
                if(mark1<0)
                {
                    throw new NegativeNumberException();
                }
                int mark2 = Convert.ToInt32(Console.ReadLine());
                if (mark2 < 0)
                {
                    throw new NegativeNumberException();
                }
                int mark3 = Convert.ToInt32(Console.ReadLine());
                if (mark3 < 0)
                {
                    throw new NegativeNumberException();
                }
                rec.Add(new student(name, mark1,mark2,mark3));
                Console.WriteLine("Marks of three subjects sucessfully added");

            }
            catch(FormatException E1)
            {
                Console.WriteLine(E1.Message);
            }
            catch(NegativeNumberException E2)
            {
                Console.WriteLine("NegativeNumberException occured");
            }
            
        }
      
    }
        class NegativeNumberException : Exception
        {
            public NegativeNumberException()
            {
                Console.WriteLine("negative number entered please enter a positive integer");
            }

        }
        class Program:student
    {
        
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.add();
            
        }
    }
}

