namespace Animals_Data_Engine;

public static class Make_Sound_Command_Handler
{
    [Handler]
    public static void Handle(Make_Sound_Command cmd) =>
        new Print_Event(cmd.Data.Child<Sound_Data>().Sound);

    [Validator]
    public static bool Validate(Make_Sound_Command cmd) => cmd.Data.Has_Child<Sound_Data>();
}
