namespace Animals_Data_Engine;

public class Print_Action_Message_Handler
    : IValidator<Print_Action_Command>,
        IHandler<Print_Action_Command>
{
    public bool Validate(Print_Action_Command cmd) => cmd.Data.Has_Child<Printer_Data>();

    public void Handle(Print_Action_Command cmd) =>
        cmd.Data.Child<Printer_Data>().Write(Get_Message(cmd));

    private static string Get_Message(Print_Action_Command cmd) =>
        $"The {cmd.Data.Name.ToLower()} is {cmd.Action.ToString().ToLower()}";
}
