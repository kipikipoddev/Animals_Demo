namespace Animals_Components_Engine;

public interface ISwim_Component : IComponent
{
    void Swim();
    bool Can_Swim { get; }
}
