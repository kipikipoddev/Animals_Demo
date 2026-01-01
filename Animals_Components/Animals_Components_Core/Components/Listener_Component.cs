namespace Animals_Components_Core;

public record Listener_Component<T> : Component
    where T : Event
{
    private readonly List<Action<T>> actions = [];

    public void Add_Action(Action<T> action) => actions.Add(action);

    public void Handle(T evnt)
    {
        foreach (var action in actions)
            action(evnt);
    }
}
