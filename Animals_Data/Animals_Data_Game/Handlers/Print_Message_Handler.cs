namespace Animals_Data_Game;

public static class Print_Message_Handler
{
    [Handler<Print_Command>]
    public static void Handle(Entity_Data entity, string message)
    {
        new Print_Event(string.Format(message + '\n', entity.Name));
    }
}
