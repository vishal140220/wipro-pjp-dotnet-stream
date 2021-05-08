using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    class Employee
    {
        public int Id;
        public string Name;
        public double Salary;
        public Employee(string n, int i, double s)
        {
            Name = n;
            Id = i;
            Salary = s;
        }
    }

    class EmployeeDAL
    {
        List<Employee>Employees = new List<Employee>();
        public bool AddEmployee(Employee e)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].Id == e.Id)
                {
                    return false;
                }
            }
            Employees.Add(e);
            return true;

        }
        public bool DeleteEmployee(int id)
        {
            foreach(var a in Employees)
            {
                
                if (a.Id == id)
                {
                    Employees.Remove(a);
                    return true;
                }
            }
            return false;
        }
        public string SearchEmpolyee(int id)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Employee e = (Employee)Employees[i];
                if (e.Id == id)
                {
                    return e.Name; ;
                }
            }
            return "Not found";

        }
        public Employee[] GetAllEmployees()
        {
            Employee[] e = new Employee[Employees.Count];
            e = Employees.ToArray();
            return e;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDAL e = new EmployeeDAL();
            Console.WriteLine(e.AddEmployee(new Employee("VISHAL",1, 100000)));
            Console.WriteLine(e.AddEmployee(new Employee("SANJAI",2, 80000)));
            Console.WriteLine(e.AddEmployee(new Employee("SANTHOSH",3, 75000)));
            Console.WriteLine(e.AddEmployee(new Employee("PRADEEP",4, 150000)));
            Console.WriteLine(e.DeleteEmployee(1));
            Console.WriteLine(e.DeleteEmployee(5));
            Console.WriteLine(e.SearchEmpolyee(2));
            Console.WriteLine(e.SearchEmpolyee(1));
            Employee[] emp = e.GetAllEmployees();
            foreach (Employee a in emp)
            {
                Console.WriteLine(a.Id + " " + a.Name + " " + a.Salary);
            }
        }
    }
}











