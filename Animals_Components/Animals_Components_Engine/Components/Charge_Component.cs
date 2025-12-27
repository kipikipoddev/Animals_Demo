namespace Animals_Components_Engine;

public record Charge_Component
    : Component,
        IValidator<Swim_Command>,
        IValidator<Walk_Command>,
        IValidator<Make_Sound_Command>,
        IValidator<Charge_Command>,
        IHandler<Swim_Command>,
        IHandler<Walk_Command>,
        IHandler<Make_Sound_Command>,
        IHandler<Charge_Command>
{
    public bool Is_Charged { get; private set; }

    public Charge_Component(bool is_charged = false)
    {
        Is_Charged = is_charged;
    }

    public bool Is_Valid(Swim_Command cmd) => Is_Charged;

    public bool Is_Valid(Walk_Command cmd) => Is_Charged;

    public bool Is_Valid(Make_Sound_Command cmd) => Is_Charged;

    public bool Is_Valid(Charge_Command cmd) => !Is_Charged;

    public void Handle(Swim_Command cmd) => Is_Charged = false;

    public void Handle(Walk_Command cmd) => Is_Charged = false;

    public void Handle(Make_Sound_Command cmd) => Is_Charged = false;

    public void Handle(Charge_Command cmd)
    {
        cmd.Entity.Print("The {0} is charging.");
        Is_Charged = true;
    }
}
