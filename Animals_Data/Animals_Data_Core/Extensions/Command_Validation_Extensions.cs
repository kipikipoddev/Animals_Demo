using System.Reflection;

namespace Animals_Data_Core;

public static class Command_Validation_Extensions
{
    public static bool Is_Valid(this Message cmd) =>
        cmd.Get_Validators().All(v => (bool)v.Invoke(cmd)!);

    public static bool Is_Invalid(this Message cmd) => !cmd.Is_Valid();

    private static IEnumerable<MethodInfo> Get_Validators(this Message cmd) =>
        cmd.GetType().Get_Methods_With_Attribute(typeof(ValidatorAttribute));
}
