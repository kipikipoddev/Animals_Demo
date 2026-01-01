namespace Animals_Components_Core;

public interface IValidator<T>
    where T : Command
{
    bool Is_Valid(T cmd);
}
