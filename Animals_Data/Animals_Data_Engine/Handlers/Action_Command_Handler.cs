namespace Animals_Data_Engine;

public static class Action_Command_Handler
{
    [Validator]
    public static bool Validate(Action_Command cmd) =>
        cmd.Data.Get_Charge_Data()?.Is_Charged ?? true;

    [Handler]
    public static void Handle(Action_Command cmd) => cmd.Data.Get_Charge_Data()?.Is_Charged = false;

    private static Charge_Data? Get_Charge_Data(this Data data) =>
        data.ChildOrDefault<Charge_Data>();
}
