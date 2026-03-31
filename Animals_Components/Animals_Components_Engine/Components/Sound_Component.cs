namespace Animals_Components_Engine;

public class Sound_Component(Printed_Actions sound) : Component, ISound_Component
{
    public bool Can_Make_Sound => Parent.Child_Or_Default<ICharge_Component>()?.Is_Charged ?? true;

    public void Make_Sound()
    {
        if (Can_Make_Sound)
        {
            Parent.Child<IPrint_Component>().Print(sound);
            Parent.Child_Or_Default<ICharge_Component>()?.Discharge();
        }
    }
}
