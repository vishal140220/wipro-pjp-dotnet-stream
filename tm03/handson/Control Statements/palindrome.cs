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
			String t = String.Copy(s);
			String rev = null;
			char[] ch = s.ToCharArray();
			for (int i=ch.Length-1;i>=0;i--)
			{
				rev+=ch[i];
				
			}
            if (t.Equals(rev)==true)
            {
            Console.WriteLine("The given word is palindrome");
			}
		}
	}
}
