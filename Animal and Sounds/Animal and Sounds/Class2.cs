// written by Ibrahim
// 02/27/25

public class Dog : Animal
{
    public Dog(string name)
        : base(name)
    {
    }

    public override string MakeSound()
    {
        return "Bark";
    }
}
