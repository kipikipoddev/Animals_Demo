using System.Reflection;

namespace Animals_Data_Core;

public static class Reflection_Extensions
{
    private static readonly HashSet<Assembly> assemblies = [];

    public static void Add(this Assembly assembly) => assemblies.Add(assembly);

    public static IEnumerable<MethodInfo> Get_Methods_With_Attribute<T>(this Type type)
        where T : Attribute =>
        typeof(T)
            .Get_Methods_With_Attribute()
            .Where(m => m.Get_Parameter_Type().IsAssignableFrom(type));

    public static object? Invoke(this MethodInfo method, params object[] args) =>
        method.Invoke(null, args);

    private static IEnumerable<MethodInfo> Get_Methods_With_Attribute(this Type att_type) =>
        Get_Methods().Where(m => m.GetCustomAttribute(att_type) != null);

    private static Type Get_Parameter_Type(this MethodInfo method) =>
        method.GetParameters().First().ParameterType;

    private static IEnumerable<MethodInfo> Get_Methods() =>
        assemblies.SelectMany(a => a.GetTypes()).SelectMany(t => t.GetMethods());
}
