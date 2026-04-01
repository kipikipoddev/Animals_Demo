public class Entity
{
    private string Name => GetType().Name.Replace('_', ' ').ToLower();

    protected void Print(string action) => Console.WriteLine($"The {Name} is {action}");
}
