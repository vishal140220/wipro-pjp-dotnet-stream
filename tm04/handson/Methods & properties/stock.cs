using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjp
{
	class stock
    {
		String name;
		String symbol;
		double pcp;
		double ccp;

		
		public stock(String name, String symbol, double pcp, double ccp)
        {
			this.name = name;
			this.symbol = symbol;
			this.pcp = pcp;
			this.ccp = ccp;
		}
		public void calc()
        {
			double perc = ((ccp - pcp) / pcp) * 100;
			Console.WriteLine("The percentage change is " + perc);
			
        }
    }
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter \n1)stock name \n2)symbol \n3)closing price \n4)current price");
			String a = Console.ReadLine();
			String b = Console.ReadLine();
			double c = Single.Parse(Console.ReadLine());
			double d = Single.Parse(Console.ReadLine());
			stock s1 = new stock(a,b,c,d);
			s1.calc();
		}
		
	}
}
    

