namespace Animals_Data_Engine;

public static class Swim_Command_Handler
{
    [Handler<Swim_Command>]
    public static void Handle(Entity_Data entity)
    {
        new Print_Event(entity, "The {0} is swimming");
    }

    [Validator<Swim_Command>]
    public static bool Validate(Entity_Data entity) => entity.Has_Child<Swim_Data>();
}
