public class Robot(IPrinter printer) : Entity(printer), ISound, ICharge
{
    protected readonly IPrinter Printer = printer;
    public bool Can_Make_Sound => Is_Charged;

    public bool Is_Charged { get; protected set; }

    public bool Can_Charge => !Is_Charged;

    public void Charge()
    {
        if (Can_Charge)
        {
            Print(Printed_Actions.Charging);
            Is_Charged = true;
        }
    }

    public virtual void Make_Sound()
    {
        if (Can_Make_Sound)
        {
            Print(Printed_Actions.Beeping);
            Is_Charged = false;
        }
    }
}
