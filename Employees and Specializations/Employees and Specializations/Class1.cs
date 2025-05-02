// written by Holbrait
// 02/27/25

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public override string ToString()
    {
        return "Employee: " + Name + ", Salary: $" + Salary;
    }
}
