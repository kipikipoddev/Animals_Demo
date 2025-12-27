namespace Animals_Data_Engine;

public static class Charge_Command_Handler
{
    [Handler<Charge_Command>]
    public static void Handle(Entity_Data entity)
    {
        var charged_data = entity.Child<Charge_Data>();
        new Print_Event(entity, "The {0} is charging.");
        charged_data.Is_Charged = true;
    }

    [Validator<Charge_Command>]
    public static bool Validate(Entity_Data entity) =>
        entity.ChildOrDefault<Charge_Data>()?.Is_Charged.Not() ?? false;
}
