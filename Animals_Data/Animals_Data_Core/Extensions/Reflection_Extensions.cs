using System.Reflection;

namespace Animals_Data_Core;

public static class Reflection_Extensions
{
    public static IEnumerable<object> Get_Assembly_Objects(
        this Assembly assembly,
        Type interface_type
    ) => assembly.Get_Interface_Types(interface_type).Select(Activator.CreateInstance)!;

    public static bool Is_Interface<T>(this object obj, Type interface_type)
        where T : Command =>
        Get_Interface_Type(obj, interface_type).Any(h => h.IsAssignableFrom(typeof(T)));

    public static IEnumerable<Type> Get_Interface_Types(
        this Assembly assembly,
        Type interface_type
    ) => assembly.GetTypes().Where(t => Has_Interface(t, interface_type));

    private static bool Has_Interface(Type type, Type interface_type) =>
        !type.IsAbstract
        && !type.IsInterface
        && type.GetInterfaces().Any(t => Is_Interface(t, interface_type));

    private static IEnumerable<Type> Get_Interface_Type(object obj, Type interface_type) =>
        obj.GetType()
            .GetInterfaces()
            .Where(i => Is_Interface(i, interface_type))
            .Select(i => i.GetGenericArguments().First());

    private static bool Is_Interface(Type type, Type interface_type) =>
        type.IsGenericType && type.GetGenericTypeDefinition() == interface_type;
}
