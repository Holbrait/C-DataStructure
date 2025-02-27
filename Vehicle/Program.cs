

using Vehicle;

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", "Camry", 2022, 4);
        Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2023, true);

        Console.WriteLine(car);
        Console.WriteLine(motorcycle);
    }
}




