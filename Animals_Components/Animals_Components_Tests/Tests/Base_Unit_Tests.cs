using Moq;

namespace Animals_Components_Tests;

[TestFixture]
public abstract class Base_Unit_Tests<T>
    where T : Component
{
    private readonly Mock<IPrint_Component> printer_mock = new();
    protected IComponent Subject;
    protected T Component;

    [SetUp]
    public virtual void SetUp()
    {
        printer_mock.Reset();
        Component = Get_Component();
        Subject = new Component().Add(printer_mock.Object).Add(Component);
    }

    protected void Verify(Printed_Actions action) =>
        printer_mock.Verify(m => m.Print(action), Times.Once);

    protected void Verify_Never() =>
        printer_mock.Verify(m => m.Print(It.IsAny<Printed_Actions>()), Times.Never);

    protected virtual T Get_Component() => Activator.CreateInstance<T>();
}
