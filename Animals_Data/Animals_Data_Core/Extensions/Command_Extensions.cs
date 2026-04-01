using System.Reflection;

namespace Animals_Data_Core;

public static class Command_Extensions
{
    public static bool Send(this Message cmd)
    {
        if (cmd.Is_Invalid())
            return false;
        foreach (var handler in cmd.Get_Handlers())
            handler.Invoke(cmd);
        return true;
    }

    private static IEnumerable<MethodInfo> Get_Handlers(this Message cmd) =>
        cmd.GetType().Get_Methods_With_Attribute(typeof(HandlerAttribute));
}
