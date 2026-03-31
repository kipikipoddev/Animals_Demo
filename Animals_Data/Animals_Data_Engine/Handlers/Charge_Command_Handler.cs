namespace Animals_Data_Engine;

public static class Charge_Command_Handler
{
    [Handler]
    public static void Handle(Charge_Command cmd)
    {
        cmd.Data.Child<Charge_Data>().Is_Charged = true;
        new Print_Event(Printed_Actions.Charging);
    }

    [Validator]
    public static bool Validate(Charge_Command cmd) =>
        cmd.Data.ChildOrDefault<Charge_Data>()?.Is_Charged.Not() ?? false;
}
