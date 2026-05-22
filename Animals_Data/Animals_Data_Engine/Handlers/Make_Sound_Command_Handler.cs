namespace Animals_Data_Engine;

public class Make_Sound_Command_Handler
    : IValidator<Make_Sound_Command>,
        IHandler<Make_Sound_Command>
{
    public bool Validate(Make_Sound_Command cmd) => cmd.Data.Has_Child<Sound_Data>();

    public void Handle(Make_Sound_Command cmd) =>
        new Print_Action_Command(cmd.Data, cmd.Data.Child<Sound_Data>().Sound).Send();
}
