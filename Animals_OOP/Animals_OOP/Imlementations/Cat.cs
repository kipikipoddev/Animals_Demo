public class Cat(IPrinter printer) : Entity(printer), ISound
{
    public bool Can_Make_Sound => true;

    public void Make_Sound() => Print(Printed_Actions.Meowing);
}
