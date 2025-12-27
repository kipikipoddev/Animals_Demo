namespace Animals_Components_Core;

public record Handler_Component<T>(IHandler<T> Handler) : Component, IHandler<T>
    where T : Event
{
    public void Handle(T evnt)
    {
        Handler.Handle(evnt);
    }
}
