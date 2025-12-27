namespace Animals_Components_Core;

public static class Command_Extensions
{
    public static object Send<T>(this T cmd)
        where T : Command
    {
        var is_valid = cmd.Is_Valid();
        if (is_valid)
            cmd.Send_Message();
        return is_valid;
    }
}
