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
			string v = Console.ReadLine();
			char[] ch1 = v.ToCharArray();
			char[] ch = s.ToCharArray();
			for(int i=0;i<ch.Length;i++)
            {
				if (ch[i].Equals(ch1[0]) == true)
				{
					count++;
				}
            }
			Console.WriteLine("{0} has repeated {1} times", v, count);
		}
	}
}
