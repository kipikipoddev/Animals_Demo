namespace Animals_Components_Engine;

public interface IComponent
{
    List<IComponent> Children { get; }
    IComponent Parent { get; set; }
}
