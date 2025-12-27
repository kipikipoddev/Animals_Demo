namespace Animals_Data_Engine;

public static class Make_Sound_Command_Handler
{
    [Handler<Make_Sound_Command>]
    public static void Handle(Entity_Data entity)
    {
        var sound = entity.Child<Sound_Data>().Sound;
        new Print_Event(entity, sound);
    }

    [Validator<Make_Sound_Command>]
    public static bool Validate(Entity_Data entity) => entity.Has_Child<Sound_Data>();
}
