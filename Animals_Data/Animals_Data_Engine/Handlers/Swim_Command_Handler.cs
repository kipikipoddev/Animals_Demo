namespace Animals_Data_Engine;

public static class Swim_Command_Handler
{
    [Validator]
    public static bool Validate(Swim_Message cmd) => cmd.Data.Has_Child<Swim_Data>();

    [Handler]
    public static void Handle(Swim_Message cmd) =>
        new Print_Action_Message(cmd.Data, Printed_Actions.Swimming).Send();
}
