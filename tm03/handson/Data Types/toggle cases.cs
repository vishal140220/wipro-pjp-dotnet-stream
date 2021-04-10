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
				if(char.IsUpper(a[i])==true)
                {
					b[i] = char.ToLower(a[i]);
                }
				else
                {
					b[i] = char.ToUpper(a[i]);
                }
            }
            String str = String.Concat(b);
			Console.WriteLine(str);


		}
	}
}
