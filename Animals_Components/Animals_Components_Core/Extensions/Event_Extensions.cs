namespace Animals_Components_Core;

public static class Event_Extensions
{
    public static void Send<T>(this T evnt)
        where T : Event => evnt.Component.ChildOrDefault<Listener_Component<T>>()?.Handle(evnt);

    public static void Add_Listner<T>(this Component component, Action<T> action)
        where T : Event
    {
        if (!component.Has_Child<Listener_Component<T>>())
            Component_Extensions.Add(component, new Listener_Component<T>());
        component.Child<Listener_Component<T>>().Add_Action(action);
    }
}
