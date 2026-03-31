using Moq;

namespace Animals_OOP_Tests;

[TestFixture]
public class Base_Unit_Tests
{
    private readonly Mock<IPrinter> printer_mock = new();
    protected IPrinter Printer => printer_mock.Object;

    public virtual void SetUp() => printer_mock.Reset();

    protected void Verify(Printed_Actions action) =>
        printer_mock.Verify(m => m.Print(action), Times.Once);

    protected void Verify_Never() =>
        printer_mock.Verify(m => m.Print(It.IsAny<Printed_Actions>()), Times.Never);
}
