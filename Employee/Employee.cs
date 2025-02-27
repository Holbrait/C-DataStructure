//written by Holbrait
//2/23/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employee: {Name}, Salary: ${Salary}";
        }
    }

    public class Manager : Employee
    {
        public int NumberOfEmployeesManaged { get; set; }

        public Manager(string name, decimal salary, int numberOfEmployeesManaged)
            : base(name, salary)
        {
            NumberOfEmployeesManaged = numberOfEmployeesManaged;
        }

        public override string ToString()
        {
            return base.ToString() + $", Manages: {NumberOfEmployeesManaged} employees";
        }
    }

    public class Engineer : Employee
    {
        public string Specialization { get; set; }

        public Engineer(string name, decimal salary, string specialization)
            : base(name, salary)
        {
            Specialization = specialization;
        }

        public override string ToString()
        {
            return base.ToString() + $", Specialization: {Specialization}";
        }
    }

    
    

}

