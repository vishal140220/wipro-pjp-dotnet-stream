using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Generics1
{
    class Employee
    {
        public int Id;
        public String Name;
        public double Salary;
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
    }

    class EmployeeDAL
    {
        List<Employee> employees = new List<Employee>();
        public bool AddEmployee(Employee e)
        {
            if (employees.Exists(emp => emp.Id == e.Id))
            {

                return false;
            }
            employees.Add(e);
            return true;
        }
        public bool DeleteEmployee(int id)
        {
            if (employees.Exists(emp => emp.Id == id))
            {
                return true;
            }
            return false;
        }
        public string SearchEmployee(int id)
        {
            if (employees.Exists(emp => emp.Id == id))
            {
                Employee e = employees.Find(emp => emp.Id == id);
                return e.Name;
            }
            return "No such Records found";
        }
        public Employee[] GetEmployees()
        {
            Employee[] e = employees.ToArray();
            return e;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            EmployeeDAL e = new EmployeeDAL();
            Console.WriteLine(e.AddEmployee(new Employee(1, "prudhvi", 50000)));
            Console.WriteLine(e.AddEmployee(new Employee(2, "nikil", 80000)));
            Console.WriteLine(e.AddEmployee(new Employee(3, "naafiya", 90000)));
            Console.WriteLine(e.AddEmployee(new Employee(4, "supriya", 20000)));
            Console.WriteLine(e.DeleteEmployee(1));
            Console.WriteLine(e.DeleteEmployee(5));
            Console.WriteLine(e.SearchEmployee(1));
            Employee[] emp = e.GetEmployees();
            foreach (Employee a in emp)
            {
                Console.WriteLine(a.Id + " " + a.Name + " " + a.Salary);
            }

        }

    }
}