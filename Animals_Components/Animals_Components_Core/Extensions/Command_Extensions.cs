using System.Reflection;

namespace Animals_Components_Core;

public static class Command_Extensions
{
    private static readonly MethodInfo Invoke_Handlers_Method =
        typeof(Command_Extensions).GetMethod(
            nameof(Invoke_Handlers),
            BindingFlags.Static | BindingFlags.NonPublic
        )!;

    public static readonly MethodInfo Get_Handlers_Method = typeof(Command_Extensions).GetMethod(
        nameof(Get_Handlers),
        BindingFlags.Static | BindingFlags.NonPublic
    )!;

    public static void Send<T>(this T cmd)
        where T : Command
    {
        if (cmd.Is_Valid())
            cmd.Get_Invoke_Handlers().Invoke(cmd).ToArray();
    }

    private static IEnumerable<MethodInfo> Get_Invoke_Handlers<T>(this T cmd)
        where T : Command => cmd.Get_Types(typeof(Command)).Get_Methods(Invoke_Handlers_Method);

    private static void Invoke_Handlers<T>(this T cmd)
        where T : Command
    {
        foreach (var handler in cmd.Get_Handlers())
            handler.Handle(cmd);
    }

    private static IHandler<T>[] Get_Handlers<T>(this T cmd)
        where T : Command => cmd.Component.Children<IHandler<T>>().ToArray();
}
