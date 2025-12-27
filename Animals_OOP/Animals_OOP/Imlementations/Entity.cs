public abstract class Entity(string name, IPrinter printer)
{
    private readonly IPrinter printer = printer;

    private string name { get; } = name.ToLower().Replace('_', ' ');

    protected void Print(string message)
    {
        printer.Print(string.Format(message, name));
    }
}
