using System;

namespace myapp
{
    interface IPayable
    {
      public void CalculatePay();
    }
    class HourlyEmployee:IPayable
    {
       public double HourWorked;
       public double PayperHour;
       public  double wages;
        public HourlyEmployee()
        {
        wages=HourWorked*PayperHour;
        }
        public void CalculatePay()
        {
            Console.WriteLine("In HourlyEmployee");
        }
     
    }
    class PermanentEmployee:IPayable
    {
        public double Basic_salary;
        public  double HRA;
        public double DA;
        public double Tax;
        public double NetPay;
        public double TotalPay;
        public PermanentEmployee()
        {
            HRA=(15*Basic_salary)/100;
            DA=(10*Basic_salary)/100;
            TotalPay=Basic_salary+HRA+DA;
            Tax=(8*TotalPay)/100;
            NetPay=TotalPay-Tax;
        }
       public void CalculatePay()
        {
            Console.WriteLine("In PermanentEmployee");
        }
    }
    class Employee
    {
        static void Main(string[] args) 
        {
            HourlyEmployee he=new  HourlyEmployee();
            PermanentEmployee pe=new PermanentEmployee();
        
        he.CalculatePay();
        pe.CalculatePay();
        }
    }
}
	