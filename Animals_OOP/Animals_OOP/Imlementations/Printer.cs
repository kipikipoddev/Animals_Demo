public abstract class Printer : IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}
