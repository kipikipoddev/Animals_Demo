public class Dog(IPrinter printer) : ISound, ISwim
{
    private readonly IPrinter printer = printer;

    public bool Can_Make_Sound => true;

    public bool Can_Swim => true;

    public void Make_Sound() => printer.Print(Printed_Actions.Woof);

    public void Swim() => printer.Print(Printed_Actions.Swimming);
}
