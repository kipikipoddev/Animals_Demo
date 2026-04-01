namespace Animals_Components_Tests;

[TestFixture]
public abstract class Entity_Unit_Tests<T>
    where T : Component
{
    private const string Name = "test";
    private string last_message;
    protected Entity_Component Subject;
    protected T Component;

    [SetUp]
    public virtual void SetUp()
    {
        last_message = string.Empty;
        Subject = new Entity_Component(Name, (action) => last_message = action);
        Component = Get_Component();
        Subject.Add(Component);
    }

    protected void Verify(Printed_Actions action) =>
        Verify_Message($"The {Name} is {action.ToString().ToLower()}");

    protected void Verify_Message(string message) => Assert.That(last_message, Is.EqualTo(message));

    protected void Verify_Never() => Assert.That(last_message, Is.Empty);

    protected virtual T Get_Component() => Activator.CreateInstance<T>();
}
