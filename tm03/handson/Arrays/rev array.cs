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
			int[] arr = new int[n];
			for(int i=0;i<n;i++)
            {
				arr[i] = Convert.ToInt32(Console.ReadLine());
            }
			for(int j=n-1;j>=0;j--)
            {
				Console.WriteLine(arr[j]);
            }

		}
	}
}
    

