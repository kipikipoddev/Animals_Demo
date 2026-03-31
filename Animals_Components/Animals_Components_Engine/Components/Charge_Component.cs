namespace Animals_Components_Engine;

public record Charge_Component : Component, ICharge_Component
{
    public bool Is_Charged { get; private set; }

    public bool Can_Charge => !Is_Charged;

    public void Charge()
    {
        if (Can_Charge)
        {
            Parent.Child<IPrint_Component>().Print(Printed_Actions.Charging);
            Is_Charged = true;
        }
    }

    public void Discharge()
    {
        Is_Charged = false;
    }
}
