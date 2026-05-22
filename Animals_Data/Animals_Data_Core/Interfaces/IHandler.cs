namespace Animals_Data_Core;

public interface IHandler<in T>
    where T : Command
{
    void Handle(T command);
}
