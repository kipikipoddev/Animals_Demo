namespace Animals_Components_Engine;

public class Component : IComponent
{
    public IComponent Parent { get; set; }

    public List<IComponent> Children { get; } = new();
}
