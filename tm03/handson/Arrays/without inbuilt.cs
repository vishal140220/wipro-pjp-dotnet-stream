using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjp
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = 0;
			int[] arr = { 1, 2, 3, 4, 5 };
			foreach (int element in arr)
            {
				count++;
            }
			Console.WriteLine("No of elements in array = " + count);
		}
		
	}
}
    

