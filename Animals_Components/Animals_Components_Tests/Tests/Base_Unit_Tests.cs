namespace Animals_Components_Tests;

[TestFixture]
public abstract class Base_Unit_Tests<T>
    where T : Component
{
    private const string Name = "test";
    private readonly List<string> messages = [];
    protected IComponent Subject;
    protected T Component;

    [SetUp]
    public virtual void SetUp()
    {
        messages.Clear();
        Component = Get_Component();
        Subject = new Component()
            .Add(new Print_Component(messages.Add))
            .Add(new Name_Component(Name))
            .Add(Component);
    }

    protected void Verify(Printed_Actions action) =>
        Verify_Message($"The {Name} is {action.ToString().ToLower()}");

    protected void Verify_Message(string message) =>
        Assert.That(messages.Last(), Is.EqualTo(message));

    protected void Verify_Never() => Assert.That(messages, Is.Empty);

    protected virtual T Get_Component() => Activator.CreateInstance<T>();
}
