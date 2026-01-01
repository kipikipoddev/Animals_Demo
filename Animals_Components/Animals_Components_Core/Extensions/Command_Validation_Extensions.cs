using System.Reflection;

namespace Animals_Components_Core;

public static class Command_Validation_Extensions
{
    private static readonly MethodInfo Is_Validators_Method =
        typeof(Command_Validation_Extensions).GetMethod(
            nameof(Is_Validators_Valid),
            BindingFlags.Static | BindingFlags.NonPublic
        )!;

    public static bool Is_Valid(this Command cmd)
    {
        var types = cmd.Get_Types(typeof(Command));
        bool is_valid = cmd.Is_Valid(types);
        return is_valid && cmd.Has_Handler(types);
    }

    private static bool Is_Valid(this Command cmd, IEnumerable<Type> types) =>
        types.Get_Methods(Is_Validators_Method).Invoke(cmd).All(o => (bool)o);

    private static bool Has_Handler(this Command cmd, IEnumerable<Type> types) =>
        types
            .Get_Methods(Command_Extensions.Get_Handlers_Method)
            .Invoke(cmd)
            .Any(o => ((object[])o).Any());

    public static bool Is_Invalid<T>(this T cmd)
        where T : Command => !cmd.Is_Valid();

    private static bool Is_Validators_Valid<T>(this T msg)
        where T : Command => msg.Component.Children<IValidator<T>>().All(v => v.Is_Valid(msg));
}
