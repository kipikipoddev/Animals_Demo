namespace Animals_Data_Engine;

public static class Action_Command_Handler
{
    [Validator<Action_Command>]
    public static bool Validate(Entity_Data entity)
    {
        return entity.Get_Charge_Data()?.Is_Charged ?? true;
    }

    [Handler<Action_Command>]
    public static void Handle(Entity_Data entity)
    {
        entity.Get_Charge_Data()?.Is_Charged = false;
    }

    private static Charge_Data? Get_Charge_Data(this Entity_Data entity) =>
        entity.ChildOrDefault<Charge_Data>();
}
