namespace Animals_Components_Engine;

public interface ICharge_Component : IComponent
{
    void Charge();
    void Discharge();
    bool Is_Charged { get; }
    bool Can_Charge { get; }
}
