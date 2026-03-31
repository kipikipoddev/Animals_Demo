namespace Animals_Data_Engine;

public static class Swim_Command_Handler
{
    [Handler]
    public static void Handle(Swim_Command cmd) => new Print_Event(Printed_Actions.Swimming);

    [Validator]
    public static bool Validate(Swim_Command cmd) => cmd.Data.Has_Child<Swim_Data>();
}
