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
            .Where(m => m.Get_Type(att_type)?.IsAssignableFrom(type) ?? false);

    public static object?[] Get_Properties(this object obj) =>
        obj.GetType().GetProperties().Select(p => p.GetValue(obj)).ToArray();

    private static Type? Get_Type(this MethodInfo method, Type att_type) =>
        method.GetCustomAttribute(att_type)?.GetType().GenericTypeArguments.First();

    private static IEnumerable<Type> Get_Types() =>
        AssemblyLoadContext
            .All.SelectMany(ctx => ctx.Assemblies)
            .Distinct()
            .Where(a => a.FullName!.Contains(Assemblies_Name))
            .SelectMany(a => a.GetTypes());
}
