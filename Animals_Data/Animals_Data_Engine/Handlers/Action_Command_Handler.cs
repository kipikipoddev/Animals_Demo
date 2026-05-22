namespace Animals_Data_Engine;

public class Action_Command_Handler : IValidator<Action_Command>, IHandler<Action_Command>
{
    public bool Validate(Action_Command cmd) => Get_Charge_Data(cmd)?.Is_Charged ?? true;

    public void Handle(Action_Command cmd) => Get_Charge_Data(cmd)?.Is_Charged = false;

    private static Charge_Data? Get_Charge_Data(Action_Command cmd) =>
        cmd.Data.ChildOrDefault<Charge_Data>();
}
