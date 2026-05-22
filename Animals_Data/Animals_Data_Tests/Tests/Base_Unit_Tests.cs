namespace Animals_Data_Tests;

[TestFixture]
public abstract class Base_Unit_Tests
{
    private string last_message = string.Empty;
    private const string Name = "test";
    protected Entity_Data Subject;

    [SetUp]
    public virtual void SetUp()
    {
        typeof(Entity_Data).Assembly.Add();
        last_message = string.Empty;
        Subject = Get_Subject();
    }

    protected void Verify(Printed_Actions action) =>
        Verify_Message($"The {Name} is {action.ToString().ToLower()}");

    protected void Verify_Message(string message) => Assert.That(last_message, Is.EqualTo(message));

    protected virtual Entity_Data Get_Subject() =>
        new Entity_Data(Name).Add(new Printer_Data(m => last_message = m));
}
