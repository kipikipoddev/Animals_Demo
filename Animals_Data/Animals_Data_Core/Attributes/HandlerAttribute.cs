namespace Animals_Data_Core;

[AttributeUsage(AttributeTargets.Method)]
public class HandlerAttribute<T> : Attribute
    where T : Message;
