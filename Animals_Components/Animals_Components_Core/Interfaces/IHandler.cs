namespace Animals_Components_Core;

public interface IHandler<T>
    where T : Message
{
    void Handle(T message);
}
