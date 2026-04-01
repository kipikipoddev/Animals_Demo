namespace Animals_Components_Engine;

public record Entity_Component(string Name, Action<string> Writer) : Component, IEntity_Component
{
    public void Print(Printed_Actions action)
    {
        var action_str = action.ToString().ToLower();
        Writer($"The {Name.ToLower()} is {action_str}");
    }
}
