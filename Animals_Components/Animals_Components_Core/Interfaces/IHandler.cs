namespace Animals_Components_Core;

public interface IHandler<T>
    where T : Command
{
    void Handle(T cmd);
}
