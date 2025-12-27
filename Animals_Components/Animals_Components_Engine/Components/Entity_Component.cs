namespace Animals_Components_Engine;

public record Entity_Component : Component
{
    public string Name { get; }

    public Entity_Component(string name)
    {
        Name = name.ToLower().Replace('_', ' ');
    }
}
