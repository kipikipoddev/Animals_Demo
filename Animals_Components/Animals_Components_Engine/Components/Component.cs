namespace Animals_Components_Engine;

public record Component : IComponent
{
    public IComponent Parent { get; set; }

    public List<IComponent> Children { get; } = new();
}
