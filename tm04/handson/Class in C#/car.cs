using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjp
{
	class car
    {
		String carname;
		int mfgYear;
		String model;
		String city;
		
		public car(String cname, int year,String model,String city)
        {
			this.carname = cname;
			this.mfgYear = year;
			this.model = model;
			this.city = city;
        }
		public void print()
        {
			Console.WriteLine(" NAME: " + carname + "\n MODEL: "+model+"\n YEAR OF MANUFACTURING: "+mfgYear+"\n MAKE: " + city);
			
        }
    }
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Type the details of your car 1)car name 2)model 3)year of manufacturing 4)city");
			String a = Console.ReadLine();
			String b = Console.ReadLine();
			int f = Convert.ToInt32(Console.ReadLine());
			String c = Console.ReadLine();
			car c1 = new car(a, f, b, c);
			c1.print();
		}
		
	}
}
    

