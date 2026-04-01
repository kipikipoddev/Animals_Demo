namespace Animals_Components_Engine;

public record Charge_Component : Component, ICharge_Component
{
    public bool Is_Charged { get; private set; }

    public bool Can_Charge => !Is_Charged;

    public Charge_Component(bool is_charged = false) => Is_Charged = is_charged;

    public void Charge()
    {
        if (Can_Charge)
            (Parent as IEntity_Component)!.Print(Printed_Actions.Charging);
        Is_Charged = true;
    }
}
