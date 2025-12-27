namespace Animals_Components_Core;

public static class Message_Validation_Extensions
{
    public static bool Is_Valid<T>(this T msg)
        where T : Message => msg.Is_Validators_Valid() && msg.Get_Handlers().Any();

    private static bool Is_Validators_Valid<T>(this T msg)
        where T : Message => msg.Component.Children<IValidator<T>>().All(v => v.Is_Valid(msg));

    public static bool Is_Invalid<T>(this T msg)
        where T : Message => !msg.Is_Valid();
}
