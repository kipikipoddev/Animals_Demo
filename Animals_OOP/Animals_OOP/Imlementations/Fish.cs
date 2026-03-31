public class Fish(IPrinter printer) : Entity(printer), ISwim
{
    public bool Can_Swim => true;

    public void Swim() => Print(Printed_Actions.Swimming);
}
