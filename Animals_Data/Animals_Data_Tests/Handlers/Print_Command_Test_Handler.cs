namespace Animals_Data_Tests;

public static class Print_Command_Test_Handler
{
    [Handler<Print_Command>]
    public static void Handle(Entity_Data entity, string message)
    {
        var formatted_message = string.Format(message, entity.Name);
        entity.Add(new Message_Data(formatted_message));
    }
}
