using System.Reflection;

namespace Animals_Data_Core;

public static class Reflection_Extensions
{
    public static IEnumerable<object> Get_Assembly_Objects(
        this Assembly assembly,
        params Type[] interface_types
    ) => assembly.Get_Interface_Types(interface_types).Select(Activator.CreateInstance)!;

    public static bool Is_Interface<T>(this object obj, params Type[] interface_types)
        where T : Command =>
        Get_Interface_Type(obj, interface_types).Any(h => h.IsAssignableFrom(typeof(T)));

    public static IEnumerable<Type> Get_Interface_Types(
        this Assembly assembly,
        params Type[] interface_types
    ) => assembly.GetTypes().Where(t => Has_Interface(t, interface_types));

    private static bool Has_Interface(Type type, Type[] interface_types) =>
        !type.IsAbstract
        && !type.IsInterface
        && type.GetInterfaces().Any(t => Is_Interface(t, interface_types));

    private static IEnumerable<Type> Get_Interface_Type(object obj, Type[] interface_types) =>
        obj.GetType()
            .GetInterfaces()
            .Where(i => Is_Interface(i, interface_types))
            .Select(i => i.GetGenericArguments().First());

    private static bool Is_Interface(Type type, Type[] interface_types) =>
        type.IsGenericType && interface_types.Contains(type.GetGenericTypeDefinition());
}
