public class Fish(IPrinter printer) : ISwim
{
    private readonly IPrinter printer = printer;

    public bool Can_Swim => true;

    public void Swim() => printer.Print(Printed_Actions.Swimming);
}
