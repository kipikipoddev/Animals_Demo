using System.Reflection;

namespace Animals_Data_Core;

public static class Request_Extensions
{
    public static object Send(this Request request) =>
        request.Get_Handler().Invoke(null, request.Get_Properties())!;

    private static MethodInfo Get_Handler(this Request request) =>
        request.GetType().Get_Methods_With_Attribute(typeof(HandlerAttribute<>)).First();
}
