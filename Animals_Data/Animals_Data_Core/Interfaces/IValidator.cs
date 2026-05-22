namespace Animals_Data_Core;

public interface IValidator<in T>
    where T : Command
{
    bool Validate(T command);
}
