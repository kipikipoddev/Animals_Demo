namespace Animals_Data_Engine;

public static class Print_Action_Message_Handler
{
    [Validator]
    public static bool Validate(Print_Action_Message cmd) =>
        cmd.Data.Has_Child<Name_Data>() && cmd.Data.Has_Child<Print_Action_Data>();

    [Handler]
    public static void Handle(Print_Action_Message cmd) =>
        cmd.Data.Child<Print_Action_Data>().Action(Get_Message(cmd));

    private static string Get_Message(Print_Action_Message cmd) =>
        $"The {cmd.Data.Child<Name_Data>().Name.ToLower()} is {cmd.Action.ToString().ToLower()}";
}
