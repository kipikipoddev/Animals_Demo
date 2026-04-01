namespace Animals_Data_Engine;

public static class Print_Action_Message_Handler
{
    [Validator]
    public static bool Validate(Print_Action_Message cmd) => cmd.Data.Has_Child<Printer_Data>();

    [Handler]
    public static void Handle(Print_Action_Message cmd) =>
        cmd.Data.Child<Printer_Data>().Write(Get_Message(cmd));

    private static string Get_Message(Print_Action_Message cmd) =>
        $"The {cmd.Data.Name.ToLower()} is {cmd.Action.ToString().ToLower()}";
}
