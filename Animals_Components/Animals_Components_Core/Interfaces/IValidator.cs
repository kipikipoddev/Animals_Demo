namespace Animals_Components_Core;

public interface IValidator<T>
    where T : Message
{
    bool Is_Valid(T message);
}
