using System.Reflection;

namespace Animals_Data_Core;

public static class Command_Send_Extensions
{
    private static readonly Type handler_interface = typeof(IHandler<>);
    private static readonly List<object> handlers = [];

    public static void Add_Handlers(this Assembly assembly) =>
        handlers.AddRange(assembly.Get_Assembly_Objects(handler_interface));

    public static bool Send<T>(this T cmd)
        where T : Command
    {
        if (!cmd.Is_Valid())
            return false;
        foreach (var handler in Get_Handlers<T>())
            handler.Handle(cmd);
        return true;
    }

    private static IEnumerable<IHandler<T>> Get_Handlers<T>()
        where T : Command =>
        handlers.Where(h => h.Is_Interface<T>(handler_interface)).Select(h => (IHandler<T>)h);
}
