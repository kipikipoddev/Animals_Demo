namespace Animals_Data_Engine;

public static class Print_Command_Handler
{
    [Handler<Print_Command>]
    public static void Handle(Entity_Data entity, string message)
    {
        var name = entity.Child<Entity_Data>().Name;
        Console.WriteLine(string.Format(message, name));
    }
}
