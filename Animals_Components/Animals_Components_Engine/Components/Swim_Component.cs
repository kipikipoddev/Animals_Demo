namespace Animals_Components_Engine;

public record Swim_Component : Component, ISwim_Component
{
    public bool Can_Swim => Parent.Child_Or_Default<ICharge_Component>()?.Is_Charged ?? true;

    public void Swim()
    {
        if (Can_Swim)
        {
            (Parent as IEntity_Component)!.Print(Printed_Actions.Swimming);
            Parent.Child_Or_Default<ICharge_Component>()?.Is_Charged = false;
        }
    }
}
