namespace Animals_Components_Core;

public static class Message_Send_Extensions
{
    public static void Send_Message<T>(this T msg)
        where T : Message
    {
        foreach (var handler in msg.Get_Handlers())
            handler.Handle(msg);
    }

    public static IHandler<T>[] Get_Handlers<T>(this T msg)
        where T : Message => msg.Component.Children<IHandler<T>>().ToArray();
}
