using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    class maths
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int sub(int a, int b, int c)
        {
            return a - b - c;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int mul(int a, int b, int c)
        {
            return a * b * c;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
        public float div(float a, float b)
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            maths m = new maths();
            int p = m.add(1, 2);
            Console.WriteLine(p);
            p = m.add(1, 2, 3);
            Console.WriteLine(p);
            p = m.sub(2, 1);
            Console.WriteLine(p);
            p = m.sub(2, 1, 1);
            Console.WriteLine(p);
            p = m.mul(1, 2);
            Console.WriteLine(p);
            p = m.mul(1, 2, 3);
            Console.WriteLine(p);
            p = m.div(10, 5);
            Console.WriteLine(p);
            float q = m.div(1.5f, 1.5f);
            Console.WriteLine(q);
        }
    }
}

