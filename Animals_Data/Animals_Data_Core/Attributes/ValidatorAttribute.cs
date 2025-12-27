namespace Animals_Data_Core;

[AttributeUsage(AttributeTargets.Method)]
public class ValidatorAttribute<T> : Attribute
    where T : Message;
