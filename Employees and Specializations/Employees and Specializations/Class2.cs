// written by Holbrait 
// 02/27/25

public class Engineer : Employee
{
    public string Specialization { get; set; }

    public Engineer(string name, double salary, string specialization)
        : base(name, salary)
    {
        Specialization = specialization;
    }

    public override string ToString()
    {
        return "Engineer: " + Name + ", Salary: $" + Salary + ", Specialization: " + Specialization;
    }
}
