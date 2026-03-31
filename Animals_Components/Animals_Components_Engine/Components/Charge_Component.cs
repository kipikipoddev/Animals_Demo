namespace Animals_Components_Engine;

public class Charge_Component(bool is_charged = false) : Component, ICharge_Component
{
    public bool Is_Charged { get; private set; } = is_charged;

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
