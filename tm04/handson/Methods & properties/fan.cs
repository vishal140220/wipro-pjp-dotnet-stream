using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjp
{   interface fan
    {
        void toString();
    }
    class home:fan 
    { 
        static int slow =1;
        static int medium = 2;
        static int fast = 3;
        private int speed = slow;
        private bool on = false;
        private int radius = 5;
        private string colour = "red";
        public home()
        {
           
        }
        public int Slow
        {
            get { return slow; }
            set { slow = value; }
        }
        public int Medium
        {
            get { return medium; }
            set { medium = value; }
        }
        public int Fast
        {
            get { return fast; }
            set { fast = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public bool On
        {
            get { return on; }
            set { on = value; }
        }
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public void toString()
        {
            Console.WriteLine("SLOW=" + slow + "\n" + "MEDIUM=" + medium + "\n" + "FAST=" + fast + "\n" + "speed=" + speed + "\n" + "on=" + on + "\n" + "radius=" + radius + "\n" + "color=" + colour);
        }


        static void Main(string[] args)
        {
            home h1 = new home();
            h1.toString();
            
        }
    }
}
