using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeA = new TeamMember("John Snow", 20000);
            Employee employeeB = new TeamMember("Bruno Mars", 45000);
            Employee teamLead = new TeamLead("Steve Smith", 75000);

            teamLead.Add(employeeA);
            teamLead.Add(employeeB);

            Console.WriteLine(teamLead.GetData());
            Console.Read();
        }
    }

    public abstract class Employee
    {
        protected string name;
        protected double salary;

        public Employee(string name, double salary)

        {
            this.name = name;
            this.salary = salary;
        }

        public abstract void Add(Employee employee);
        public abstract void Remove(Employee employee);
        public abstract string GetData();
    }

    public class TeamLead : Employee
    {
        List<Employee> lstEmployee = new List<Employee>();

        public TeamLead(string name, double salary) : base(name, salary) { }

        public override void Add(Employee employee)
        {
            lstEmployee.Add(employee);
        }

        public override void Remove(Employee employee)
        {
            lstEmployee.Remove(employee);
        }

        public override string GetData()
        {
            StringBuilder sbEmployee = new StringBuilder();

            foreach (Employee emp in lstEmployee)
            {
                sbEmployee.Append(emp.GetData() + "\n");
            }
            return sbEmployee.ToString();
        }
    }

    public class TeamMember : Employee
    {
        public TeamMember(string name, double salary) : base(name, salary) { }

        public override void Add(Employee employee)
        {
            //Operation not permitted since this is a leaf node.
        }
        public override void Remove(Employee employee)
        {
            //Operation not permitted since this is a leaf node.
        }
        public override string GetData()
        {
            return "Name: " + name + "\tSalary: " + salary.ToString("N2");
        }
    }
}
