using System.Reflection;

namespace Animals_Data_Core;

public static class Command_Validation_Extensions
{
    public static bool Is_Valid(this Command cmd)
    {
        var ars = cmd.Get_Properties();
        return cmd.Get_Validators().All(v => (bool)v.Invoke(null, ars)!);
    }

    public static bool Is_Invalid(this Command cmd) => !cmd.Is_Valid();

    private static IEnumerable<MethodInfo> Get_Validators(this Command cmd) =>
        cmd.GetType().Get_Methods_With_Attribute(typeof(ValidatorAttribute<>));
}
