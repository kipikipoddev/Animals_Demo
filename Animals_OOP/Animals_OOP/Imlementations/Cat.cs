public class Cat(IPrinter printer) : ISound
{
    private readonly IPrinter printer = printer;

    public bool Can_Make_Sound => true;

    public void Make_Sound() => printer.Print(Printed_Actions.Meow);
}
