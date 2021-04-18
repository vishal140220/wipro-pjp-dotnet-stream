using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjp
{
	interface Ipayable
    {
		 void display();


	}
	class HourlyEmployee :Ipayable
        {
			double hourworked;
			double payperhour;
			double wages;
			public HourlyEmployee(double HourWorked, double PayperHour)
			{
				wages = HourWorked * PayperHour;
			}
			public void display()
            {
				Console.WriteLine("Display invoked from HourlyEmployee");
            }
		}
	class PermanentEmployee:Ipayable
        {
			double HRA, DA, tax, Netpay, Totalpay;
			public PermanentEmployee(double Basic_salary)
			{
				HRA = (15 * Basic_salary) / 100;
				DA = (10 * Basic_salary) / 100;
				Totalpay = Basic_salary + HRA + DA;
				tax = (8 * Totalpay) / 100;
				Netpay = Totalpay - tax;
			}
			public void display()
            {
				Console.WriteLine("Display invoked from PermanentEmployee");
			}
		}
		class Employee
		{
			
			
			static void Main(String[] args)
			{
			HourlyEmployee he1 = new HourlyEmployee(8, 300);
			PermanentEmployee pe1 = new PermanentEmployee(18000);
			he1.display();
			pe1.display();

			
			}
		}

}

