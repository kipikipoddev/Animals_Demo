using System.Reflection;
using System.Runtime.Loader;

namespace Animals_Data_Core;

public static class Reflection_Extensions
{
    private const string Assemblies_Name = "Data";

    public static IEnumerable<MethodInfo> Get_Methods_With_Attribute(
        this Type type,
        Type att_type
    ) =>
        att_type
            .Get_Methods_With_Attribute()
            .Where(m => m.Get_Parameter_Type().IsAssignableFrom(type));

    public static object? Invoke(this MethodInfo method, params object[] args) =>
        method.Invoke(null, args);

    private static IEnumerable<MethodInfo> Get_Methods_With_Attribute(this Type att_type) =>
        Get_Types()
            .SelectMany(t => t.GetMethods())
            .Where(m => m.GetCustomAttribute(att_type) != null);

    private static Type Get_Parameter_Type(this MethodInfo method) =>
        method.GetParameters().First().ParameterType;

    private static IEnumerable<Type> Get_Types() =>
        AssemblyLoadContext
            .All.SelectMany(ctx => ctx.Assemblies)
            .Distinct()
            .Where(a => a.FullName!.Contains(Assemblies_Name))
            .SelectMany(a => a.GetTypes());
}
