namespace Animals_Components_Core;

public static class Event_Extensions
{
    public static void Send<T>(this T evnt)
        where T : Event => evnt.Send_Message();

    public static void Add_Handler<T>(this IHandler<T> handler, Component component)
        where T : Event => component.Add(new Handler_Component<T>(handler));
}
