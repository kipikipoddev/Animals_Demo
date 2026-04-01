namespace Animals_Components_Tests;

[TestFixture]
public abstract class Base_Unit_Tests<T>
    where T : Component
{
    private const string Name = "test";
    private string last_message;
    protected IComponent Subject;
    protected T Component;

    [SetUp]
    public virtual void SetUp()
    {
        last_message = string.Empty;
        Component = Get_Component();
        Subject = new Component()
            .Add(new Print_Component(m => last_message = m))
            .Add(new Name_Component(Name))
            .Add(Component);
    }

    protected void Verify(Printed_Actions action) =>
        Verify_Message($"The {Name} is {action.ToString().ToLower()}");

    protected void Verify_Message(string message) => Assert.That(last_message, Is.EqualTo(message));

    protected void Verify_Never() => Assert.That(last_message, Is.Empty);

    protected virtual T Get_Component() => Activator.CreateInstance<T>();
}
