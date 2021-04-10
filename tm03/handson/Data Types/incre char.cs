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
			char [] a =s.ToCharArray();
			char[] b = new char[a.Length];
				for(int i=0;i<a.Length;i++)
            {
				char ch = a[i];
				ch++;
				b[i] = ch;
            }
			String str = String.Concat(b);
			Console.WriteLine(str);


		}
	}
}
