namespace Animals_Components_Engine;

public record Print_Component(Action<string> Write) : Component, IPrint_Component
{
    public void Print(Printed_Actions action)
    {
        var name = Parent.Child<IName_Component>().Name.ToLower();
        var action_str = action.ToString().ToLower();
        Write($"The {name} is {action_str}");
    }
}
