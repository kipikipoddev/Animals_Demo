using System.Reflection;

namespace Animals_Components_Core;

public static class Type_Extensions
{
    public static IEnumerable<object?> Invoke(
        this IEnumerable<MethodInfo> methods,
        params object[] args
    )
    {
        foreach (var method in methods)
            yield return method.Invoke(null, args);
    }

    public static IEnumerable<MethodInfo> Get_Methods(
        this IEnumerable<Type> types,
        MethodInfo method
    ) => types.Select(t => method.MakeGenericMethod(t));

    public static IEnumerable<Type> Get_Types(this object obj, Type last_type)
    {
        var type = obj.GetType();
        do
        {
            yield return type;
            type = type.BaseType!;
        } while (!type.Equals(last_type));
    }
}
