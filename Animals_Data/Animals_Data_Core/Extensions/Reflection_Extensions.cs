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
        Get_Types()
            .SelectMany(t => t.GetMethods())
            .Where(m => m.Get_Parameter_Type()?.IsAssignableFrom(type) ?? false);

    public static object? Invoke(this MethodInfo method, params object[] args) =>
        method.Invoke(null, args);

    private static Type? Get_Parameter_Type(this MethodInfo method) =>
        method.GetParameters().FirstOrDefault()?.ParameterType;

    private static IEnumerable<Type> Get_Types() =>
        AssemblyLoadContext
            .All.SelectMany(ctx => ctx.Assemblies)
            .Distinct()
            .Where(a => a.FullName!.Contains(Assemblies_Name))
            .SelectMany(a => a.GetTypes());
}
