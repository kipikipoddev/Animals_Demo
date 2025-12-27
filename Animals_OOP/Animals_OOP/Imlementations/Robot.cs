public class Robot : Animal, ICharge
{
    public bool Is_Charged { get; protected set; }

    public Robot(string name, IPrinter printer)
        : base(name, printer) { }

    public Robot(IPrinter printer)
        : base(nameof(Robot), printer) { }

    protected override int Leg_Count => 2;

    public override void Make_Sound()
    {
        if (Can_Make_Sound)
            Print("Beep");
        Is_Charged = false;
    }

    public override void Walk()
    {
        base.Walk();
        Is_Charged = false;
    }

    public void Charge()
    {
        if (Can_Charge)
            Print("The {0} is charging.");
        Is_Charged = true;
    }

    public bool Can_Charge => !Is_Charged;

    public override bool Can_Make_Sound => Is_Charged;

    public override bool Can_Walk => Is_Charged;
}
