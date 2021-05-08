using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace myapp
{
    class Employee
    {
        public int Id;
        public string Name;
        public double Salary;
        public Employee(string n, int i, Double s)
        {
            Name = n;
            Id = i;
            Salary = s;
        }
        public string name
        { get { return Name; }
            set { Name = value; }
        }
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public double salary
        {
            get { return Salary; }
            set { Salary = value; }
        }

    }

    class EmployeeDAL
    {
        SortedList Employees = new SortedList();
        int ind = 0;
        public bool AddEmployee(Employee e)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Employee emp = (Employee)Employees[i];

                if (emp.id == e.Id)
                {
                    return false;
                }
            }
            Employees.Add(ind, e);
            ind++;
            return true;

        }
        public bool DeleteEmployee(int id)
        {
            for(int i= 0;i<Employees.Count;i++)
            {  Employee e = (Employee)Employees[i];
                if ( e.id== id)
                {
                    Employees.Remove(i);
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
                if (e.id == id)
                {
                    return e.Name; ;
                }
            }
            return "Not such item Exist";

        }
        public Employee[] GetAllEmployees()
        {
            Employee[] e = new Employee[Employees.Count];
            for (int i = 0; i < Employees.Count; i++)
            {
                e[i] = (Employee)Employees[i];
            }
            return e;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDAL e = new EmployeeDAL();
            Console.WriteLine(e.AddEmployee(new Employee("SANTHOSH", 1, 48000)));
            Console.WriteLine(e.AddEmployee(new Employee("SANJAI", 2, 65000)));
            Console.WriteLine(e.AddEmployee(new Employee("VISHAL", 3, 55413)));
            Console.WriteLine(e.AddEmployee(new Employee("PRADEEP", 4, 150000)));
            //Console.WriteLine(e.DeleteEmployee(2));
            //Console.WriteLine(e.DeleteEmployee(5));
            Console.WriteLine(e.SearchEmpolyee(002));
            Console.WriteLine(e.SearchEmpolyee(004));
            Employee[] emp = e.GetAllEmployees();
            foreach (Employee a in emp)
            {
                Console.WriteLine(a.Id + " " + a.Name + " " + a.Salary);
            }
        }
    }
}












