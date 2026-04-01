namespace Animals_Data_Engine;

public static class Charge_Command_Handler
{
    [Validator]
    public static bool Validate(Charge_Message cmd) => cmd.Data.Has_Child<Charge_Data>();

    [Handler]
    public static void Handle(Charge_Message cmd)
    {
        new Print_Action_Message(cmd.Data, Printed_Actions.Charging).Send();
        cmd.Data.Child<Charge_Data>().Is_Charged = true;
    }
}
