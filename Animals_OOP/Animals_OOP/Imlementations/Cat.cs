public class Cat : Animal
{
    public Cat(IPrinter printer)
        : base(nameof(Cat), printer) { }

    public override void Make_Sound()
    {
        Print("Meow");
    }
}
