using System.Reflection;

namespace Animals_Data_Core;

public static class Command_Validation_Extensions
{
    private static readonly Type validator_interface = typeof(IValidator<>);
    private static readonly List<object> validators = [];

    public static void Add_Validators(this Assembly assembly) =>
        validators.AddRange(assembly.Get_Assembly_Objects(validator_interface));

    public static bool Is_Valid<T>(this T cmd)
        where T : Command => Get_Validators<T>().All(validator => validator.Validate(cmd));

    public static bool Is_Invalid<T>(this T cmd)
        where T : Command => !cmd.Is_Valid();

    private static IEnumerable<IValidator<T>> Get_Validators<T>()
        where T : Command =>
        validators.Where(v => v.Is_Interface<T>(validator_interface)).Select(v => (IValidator<T>)v);
}
