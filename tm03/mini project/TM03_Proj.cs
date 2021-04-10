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
			int a = Convert.ToInt32(Console.ReadLine());
			String[] arr = new String[a];
			for(int i=0;i<a;i++)
            {
				String s = Console.ReadLine();
				int m = Convert.ToInt32(Console.ReadLine());
				int n = Convert.ToInt32(Console.ReadLine());
				if (n < s.Length - 1)
				{ arr[i] = work(s, m, n); }
				else
                {
					arr[i] = work1(s, m, n);
                }
				
			}
			for(int j=0;j<a;j++)
            {
				Console.WriteLine(arr[j]);
            }
		}
		static void reverse(char[] a)
		{
			int i, n = a.Length;
			char t;
			for (i = 0; i < n / 2; i++)
			{
				t = a[i];
				a[i] = a[n - i - 1];
				a[n - i - 1] = t;
			}
		}
		static String work(String s, int m ,int n)
        {
			
				string start = s.Substring(0, m);
				string mid = s.Substring(m, n);
				char[] ch = mid.ToCharArray();
				Array.Sort(ch);
				reverse(ch);
				String end = s.Substring(n + 1, (s.Length - 1 - n));
				return(start + new string(ch) + end);
		
			
		}
		static String work1(String s, int m, int n)
		{

			string start = s.Substring(0, m);
			string end = s.Substring(m, n+1);
			char[] ch = end.ToCharArray();
			Array.Sort(ch);
			reverse(ch);
			return (start + new string(ch));


		}

	}
}
    

