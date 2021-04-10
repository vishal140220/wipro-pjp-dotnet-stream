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
			int b = Convert.ToInt32(Console.ReadLine());
			int count = 0;
			while(a>0)
            {
				int r = b % 10;
				if(r==b)
                {
					count++;
					b = b / 10;
					break;
                }
				else
                {
					b = b / 10;
                }
            }

			if(count==1)
            {
				Console.WriteLine("Tens position");
            }
			else if (count == 2)
			{
				Console.WriteLine("Hundreds position");
			}
			else if (count == 3)
			{
				Console.WriteLine("Thousands position");
			}
		}
	}
}
