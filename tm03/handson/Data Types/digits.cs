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
			int count = 0;
			char [] ch =s.ToCharArray();
			for(int i=0;i<ch.Length;i++)
            {
				if(char.IsDigit(ch[i])==true)
                {
					count++;
                }
            }
			Console.WriteLine("The no of digits in the string is " + count);


		}
	}
}
