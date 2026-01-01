namespace Animals_Components_Core;

public static class Command_Extensions
{
    public static void Send<T>(this T cmd)
        where T : Command
    {
        if (cmd.Is_Valid())
            foreach (var handler in cmd.Get_Handlers())
                handler.Handle(cmd);
    }

    public static IHandler<T>[] Get_Handlers<T>(this T cmd)
        where T : Command => cmd.Component.Children<IHandler<T>>().ToArray();
}
