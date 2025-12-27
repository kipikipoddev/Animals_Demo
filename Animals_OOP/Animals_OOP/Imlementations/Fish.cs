public class Fish : Entity, ISwim
{
    public Fish(IPrinter printer)
        : base(nameof(Fish), printer) { }

    public bool Can_Swim => true;

    public void Swim()
    {
        if (Can_Swim)
            Print("The {0} is swimming.");
    }
}
