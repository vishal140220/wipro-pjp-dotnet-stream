using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    interface IPayable
    {
        void CalculatePay();
    }
    class HourlyEmployee : IPayable
    {
        public double HourWorked;
        public double PayperHour;
        public double wages;
        public HourlyEmployee(double HourWorked, double PayperHour)
        {
            this.HourWorked = HourWorked;
            this.PayperHour = PayperHour;
        }

        public void CalculatePay()
        {
            wages = HourWorked * PayperHour;
        }

    }
    class PermanentEmployee : IPayable
    {
        public double Basic_salary;
        public double HRA;
        public double DA;
        public double Tax;
        public double NetPay;
        public double TotalPay;
        public PermanentEmployee(double Basic_salary)
        {
            this.Basic_salary = Basic_salary;
        }

        public void CalculatePay()
        {
            HRA = (15 * Basic_salary) / 100;
            DA = (10 * Basic_salary) / 100;
            TotalPay = Basic_salary + HRA + DA;
            Tax = (8 * TotalPay) / 100;
            NetPay = TotalPay - Tax;
        }
    }
    class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the basic salary");
            double Basic_salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the number of hours");
            double HourWorked = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the hourly pay");
            double PayperHour = Convert.ToDouble(Console.ReadLine());
            HourlyEmployee he = new HourlyEmployee(HourWorked, PayperHour);
            PermanentEmployee pe = new PermanentEmployee(Basic_salary);


            he.CalculatePay();
            pe.CalculatePay();
            Console.WriteLine("Permanent employee");
            Console.WriteLine("Basic Salary : " + Basic_salary);
            Console.WriteLine("House Rent Allowance(HRA) : " + pe.HRA);
            Console.WriteLine("Dearness Allowance(DA) : " + pe.DA);
            Console.WriteLine("Total pay : " + pe.TotalPay);
            Console.WriteLine("Tax : " + pe.Tax);
            Console.WriteLine("Net pay : " + pe.NetPay);
            Console.WriteLine("\nHourly employe");
            Console.WriteLine("daily wage : " + he.wages);
        }
    }
}

