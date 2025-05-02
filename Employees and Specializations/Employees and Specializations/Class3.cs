// written by Holbrait
// 02/27/25

public class Manager : Employee
{
    public int NumberOfEmployeesManaged { get; set; }

    public Manager(string name, double salary, int numberOfEmployeesManaged)
        : base(name, salary)
    {
        NumberOfEmployeesManaged = numberOfEmployeesManaged;
    }

    public override string ToString()
    {
        return "Manager: " + Name + ", Salary: $" + Salary + ", Employees Managed: " + NumberOfEmployeesManaged;
    }
}
