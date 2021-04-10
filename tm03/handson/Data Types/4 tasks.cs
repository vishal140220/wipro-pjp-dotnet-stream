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
			String v = Console.ReadLine();
			pal(v);
			sub(v);
			String b = String.Copy(v);
			Console.WriteLine("The string is copied and modified to {0} the original string is {1}", b.ToUpper(), v);
			String n = v.Replace('m','$');
			Console.WriteLine("The m character is replaced with $---" + n);
		}
		public static void pal(String a)
		{
			String rev = null;
			char[] ch = a.ToCharArray();
			for (int i = a.Length - 1; i >= 0; i--)
			{
				rev += ch[i];
			}
			Console.WriteLine(rev);
		}
		public static void sub(string a)
		{
			String x = a.Substring(1, a.Length - 1);
			Console.WriteLine(x);
		}

	}
}
    

