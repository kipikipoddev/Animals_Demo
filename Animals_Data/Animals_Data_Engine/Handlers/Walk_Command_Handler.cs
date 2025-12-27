namespace Animals_Data_Engine;

public static class Walk_Command_Handler
{
    [Handler<Walk_Command>]
    public static void Handle(Entity_Data entity)
    {
        var legs_count = entity.Child<Walk_Data>().Legs_Count;
        new Print_Command(entity, "The {0} is walking on " + legs_count + " legs.");
    }

    [Validator<Walk_Command>]
    public static bool Validate(Entity_Data entity) => entity.Has_Child<Walk_Data>();
}
