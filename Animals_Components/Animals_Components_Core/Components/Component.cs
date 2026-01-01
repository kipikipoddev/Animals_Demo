namespace Animals_Components_Core;

public record Component
{
    private readonly List<Component> children = [];
    public IEnumerable<Component> Children => children;

    public bool ShouldSerializeChildren() => children.Count != 0;

    public void Add_Child(Component component) => children.Add(component);
}
