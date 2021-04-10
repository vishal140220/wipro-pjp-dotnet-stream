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
			int n = Convert.ToInt32(Console.ReadLine());
			int sum = 0;
			int[] arr = new int[n];
			for(int i=0;i<n;i++)
            {
				arr[i] = Convert.ToInt32(Console.ReadLine());
				sum = sum + arr[i];
            }
			Console.WriteLine("The sum of the array elements are : " + sum);
			
		}
		
	}
}
    

