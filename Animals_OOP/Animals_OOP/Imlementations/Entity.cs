public class Entity(IPrinter printer)
{
    private readonly IPrinter printer = printer;
    public string Name => GetType().Name.Replace('_', ' ').ToLower();

    public void Print(Printed_Actions action) =>
        printer.Print($"The {Name} is {action.ToString().ToLower()}");
}
