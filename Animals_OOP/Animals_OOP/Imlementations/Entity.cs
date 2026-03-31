public class Entity
{
    private string Name => GetType().Name.Replace('_', ' ').ToLower();

    protected void Print(Printed_Actions action) =>
        Console.WriteLine($"The {Name} is {action.ToString().ToLower()}");
}
