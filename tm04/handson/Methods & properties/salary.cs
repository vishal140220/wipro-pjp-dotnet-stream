using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjp
{
	class employee
    {
		float hra;
		float da;
		float tax;
		float grosspay;
		float net_salary;
		float basic;
		String name;
		
		public employee(String name, float basic)
        {
			this.name = name;
			this.basic = basic;
		}
		public void calc()
        {
			hra = ((15 * basic) / 100);
			da = ((10 * basic) / 100);
			grosspay = basic + da + hra;
			tax = ((8 * grosspay) / 100);
			net_salary = grosspay + tax;
			Console.WriteLine("Net salary for {0} is " + net_salary,name);
			
        }
    }
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter name and basic salary");
			String a = Console.ReadLine();
			float b = Single.Parse(Console.ReadLine());
			employee e1 = new employee(a,b);
			e1.calc();
		}
		
	}
}
    

