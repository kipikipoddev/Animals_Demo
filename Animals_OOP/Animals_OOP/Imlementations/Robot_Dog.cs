public class Robot_Dog(IPrinter printer) : Robot(printer), ISwim
{
    public bool Can_Swim => Is_Charged;

    public void Swim()
    {
        if (Can_Swim)
        {
            Printer.Print(Printed_Actions.Swimming);
            Is_Charged = false;
        }
    }

    public override void Make_Sound()
    {
        if (Can_Make_Sound)
        {
            Printer.Print(Printed_Actions.Woof);
            Is_Charged = false;
        }
    }
}
