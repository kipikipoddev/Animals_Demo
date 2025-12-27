namespace Animals_Data_Core;

public static class Event_Extensions
{
    private static readonly List<Listener_Data> listeners = [];

    public static void Send(this Event envt)
    {
        foreach (var listener in listeners.Where(l => l.Event_Type == envt.GetType()))
            listener.Action(envt);
    }

    public static void Add_Listener<T>(this IListener<T> listener)
        where T : Event
    {
        listeners.Add(new Listener_Data(typeof(T), (e) => listener.On_Event((T)e)));
    }

    private record Listener_Data(Type Event_Type, Action<Event> Action) { }
}
