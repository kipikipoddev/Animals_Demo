namespace Animals_Components_Core;

public static class Command_Validation_Extensions
{
    public static bool Is_Valid<T>(this T msg)
        where T : Command => msg.Is_Validators_Valid() && msg.Get_Handlers().Any();

    public static bool Is_Invalid<T>(this T msg)
        where T : Command => !msg.Is_Valid();

    private static bool Is_Validators_Valid<T>(this T msg)
        where T : Command => msg.Component.Children<IValidator<T>>().All(v => v.Is_Valid(msg));
}
