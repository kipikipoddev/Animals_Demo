namespace Animals_Data_Engine;

public class Swim_Command_Handler : IValidator<Swim_Command>, IHandler<Swim_Command>
{
    public bool Validate(Swim_Command cmd) => cmd.Data.Has_Child<Swim_Data>();

    public void Handle(Swim_Command cmd) =>
        new Print_Action_Command(cmd.Data, Printed_Actions.Swimming).Send();
}
