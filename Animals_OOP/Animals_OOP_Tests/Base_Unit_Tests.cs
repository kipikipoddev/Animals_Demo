using Moq;

namespace Animals_OOP_Tests;

[TestFixture]
public class Base_Unit_Tests<T>
{
    private readonly Mock<IPrinter> printer_mock = new();
    protected IPrinter Printer => new Printer(); //printer_mock.Object;
    protected T Subject;

    public virtual void SetUp() => printer_mock.Reset();

    protected void Verify(Printed_Actions action) =>
        printer_mock.Verify(
            m => m.Print($"The {Name} is {action.ToString().ToLower()}"),
            Times.Once
        );

    protected void Verify_Never() =>
        printer_mock.Verify(m => m.Print(It.IsAny<string>()), Times.Never);

    private string Name => Subject.GetType().Name.Replace('_', ' ').ToLower();
}

class Printer : IPrinter
{
    public void Print(string message) => Console.WriteLine(message);
}
