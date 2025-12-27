namespace Animals_Components_Core;

public record Component
{
    public List<Component> Children { get; } = [];

    public bool ShouldSerializeChildren() => Children.Count != 0;
}
