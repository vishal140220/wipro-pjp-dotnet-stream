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
			String s = Console.ReadLine();
			char[] ch = s.ToCharArray();
			if(char.IsDigit(ch[0])==true)
            {
				Console.WriteLine("Its a number");
            }
			else
            {
				Console.WriteLine("Its not a number");
            }

		}
	}
}
