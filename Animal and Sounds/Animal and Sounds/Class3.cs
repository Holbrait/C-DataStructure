// written by Holbrait
// 02/27/25

public class Cat : Animal
{
    public Cat(string name)
        : base(name)
    {
    }

    public override string MakeSound()
    {
        return "Meow";
    }
}
