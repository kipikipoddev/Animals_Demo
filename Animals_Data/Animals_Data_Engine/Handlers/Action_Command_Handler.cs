namespace Animals_Data_Engine;

public static class Action_Command_Handler
{
    [Validator]
    public static bool Validate(Action_Message cmd) => Get_Charge_Data(cmd)?.Is_Charged ?? true;

    [Handler]
    public static void Handle(Action_Message cmd) => Get_Charge_Data(cmd)?.Is_Charged = false;

    private static Charge_Data? Get_Charge_Data(Action_Message cmd) =>
        cmd.Data.ChildOrDefault<Charge_Data>();
}
