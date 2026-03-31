public class Robot(IPrinter printer) : ISound, ICharge
{
    protected readonly IPrinter Printer = printer;
    public bool Can_Make_Sound => Is_Charged;

    public bool Is_Charged { get; protected set; }

    public bool Can_Charge => !Is_Charged;

    public void Charge()
    {
        if (Can_Charge)
        {
            Printer.Print(Printed_Actions.Charging);
            Is_Charged = true;
        }
    }

    public virtual void Make_Sound()
    {
        if (Can_Make_Sound)
        {
            Printer.Print(Printed_Actions.Beep);
            Is_Charged = false;
        }
    }
}
