namespace Animals_Components_Engine;

public interface IEntity_Component : IComponent
{
    string Name { get; }
    void Print(Printed_Actions action);
}
