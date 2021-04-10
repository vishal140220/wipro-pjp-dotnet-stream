using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjp
{
	class RandomHelper
    { int a, b;

		public RandomHelper(int a,int b)
        {
			this.a = a;
			this.b = b;
        }
		public void randint()
        {
			Random rd = new Random();
			int v = rd.Next(a, b);
			Console.WriteLine("The random integer between given numbers is : "+ v);
			}
		public void randdouble()
        {
			Random rd = new Random();
			double x = rd.NextDouble();
			int y = rd.Next(a, b);
			Console.WriteLine("The random double between given numbers is : "+ (x*y+a));
	        }
    }
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter two integers");
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
			RandomHelper r1 = new RandomHelper(a, b);
			r1.randint();
			r1.randdouble();


		}
		
	}
}
    

