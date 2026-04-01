namespace Animals_Components_Engine;

public interface ICharge_Component : IComponent
{
    void Charge();
    bool Can_Charge { get; }
    bool Is_Charged { get; }
}
