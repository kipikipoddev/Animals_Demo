namespace Animals_Data_Engine;

public static class Make_Sound_Command_Handler
{
    [Validator]
    public static bool Validate(Make_Sound_Message cmd) => cmd.Data.Has_Child<Sound_Data>();

    [Handler]
    public static void Handle(Make_Sound_Message cmd) =>
        new Print_Action_Message(cmd.Data, cmd.Data.Child<Sound_Data>().Sound).Send();
}
