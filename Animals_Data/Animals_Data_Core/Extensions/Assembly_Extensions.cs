using System.Reflection;

namespace Animals_Data_Core;

public static class Assembly_Extensions
{
    public static void Add(this Assembly assembly)
    {
        assembly.Add_Handlers();
        assembly.Add_Validators();
    }
}
