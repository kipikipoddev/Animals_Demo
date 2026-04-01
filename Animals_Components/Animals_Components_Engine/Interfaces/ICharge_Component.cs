namespace Animals_Components_Engine;

public interface ICharge_Component : IComponent
{
    void Charge();
    bool Is_Charged { get; }
}
