namespace Animals_Components_Engine;

public record Charge_Component
    : Component,
        IValidator<Action_Command>,
        IValidator<Charge_Command>,
        IHandler<Action_Command>,
        IHandler<Charge_Command>
{
    public bool Is_Charged { get; private set; }

    public Charge_Component(bool is_charged = false)
    {
        Is_Charged = is_charged;
    }

    public bool Is_Valid(Action_Command cmd) => Is_Charged;

    public bool Is_Valid(Charge_Command cmd) => !Is_Charged;

    public void Handle(Action_Command cmd) => Is_Charged = false;

    public void Handle(Charge_Command cmd)
    {
        cmd.Entity.Print("The {0} is charging.");
        Is_Charged = true;
    }
}
