using System.Reflection;

namespace Animals_Data_Core;

public static class Command_Extensions
{
    public static bool Send(this Command cmd)
    {
        if (!cmd.Is_Valid())
            return false;
        var ars = cmd.Get_Properties();
        foreach (var handler in cmd.Get_Handlers())
            handler.Invoke(null, ars);
        return true;
    }

    private static IEnumerable<MethodInfo> Get_Handlers(this Command cmd) =>
        cmd.GetType().Get_Methods_With_Attribute(typeof(HandlerAttribute<>));
}
