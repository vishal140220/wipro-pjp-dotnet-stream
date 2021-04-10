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
			int a = Convert.ToInt32(Console.ReadLine());
			int b;
			// increment then assign
			b = ++a;
			Console.WriteLine("After prefix: {0}, {1}", a, b);

			// assign then increment
			b = a++;
			Console.WriteLine("After postfix: {0}, {1}", a, b);

			Console.WriteLine("Before Swapping a = {0} and b = {1}", a,b);
			int temp = a;
			a = b;
			b = temp;
			Console.WriteLine("After Swapping a = {0} and b = {1}", a,b);



		}
	}
}
