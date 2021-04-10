using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter the measurement of square's side");
			int a = Convert.ToInt32(Console.ReadLine());
			int area = a * a;
            Console.WriteLine("The area of the square = " + area);

		}
	}
}
