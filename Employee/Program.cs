
using Employee;

public class Program
{
    public static void Main()
    {
        Employee emp = new Employee("Alice", 50000m);
        Manager mgr = new Manager("Bob", 80000m, 5);
        Engineer eng = new Engineer("Charlie", 70000m, "Software Development");

        Console.WriteLine(emp);
        Console.WriteLine(mgr);
        Console.WriteLine(eng);
    }
}



