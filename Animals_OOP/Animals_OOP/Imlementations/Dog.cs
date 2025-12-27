public class Dog : Animal, ISwim
{
    public Dog(string name, IPrinter printer)
        : base(name, printer) { }

    public Dog(IPrinter printer)
        : base(nameof(Dog), printer) { }

    public override void Make_Sound()
    {
        if (Can_Make_Sound)
            Print("Woof!");
    }

    public void Swim()
    {
        if (Can_Swim)
            Print("The {0} is swimming.");
    }

    public bool Can_Swim => true;
}
