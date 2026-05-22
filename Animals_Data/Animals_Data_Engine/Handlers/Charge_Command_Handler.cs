namespace Animals_Data_Engine;

public class Charge_Command_Handler : IValidator<Charge_Command>, IHandler<Charge_Command>
{
    public bool Validate(Charge_Command cmd) =>
        cmd.Data.ChildOrDefault<Charge_Data>()?.Is_Charged == false;

    public void Handle(Charge_Command cmd)
    {
        new Print_Action_Command(cmd.Data, Printed_Actions.Charging).Send();
        cmd.Data.Child<Charge_Data>().Is_Charged = true;
    }
}
