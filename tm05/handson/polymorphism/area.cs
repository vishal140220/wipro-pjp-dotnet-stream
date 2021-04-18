using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    class Area
    {
        public void area(double radius)
        {

            double AREA = 3.14 * radius * radius;
            Console.WriteLine("Area of circle: "+AREA);
        }

        public void area(int length, int breadth)
        {

            int AREA = length * breadth;
            Console.WriteLine("Area of rectangle: "+AREA);
        }

        public void area(float Base, float height)
        {

            float trArea = (Base * height) / 2;
            Console.WriteLine("Area of triangle: "+trArea);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area a = new Area();
            a.area(5);
            a.area(5, 4);
            a.area(4.5f, 5.6f);
        }
    }
}

