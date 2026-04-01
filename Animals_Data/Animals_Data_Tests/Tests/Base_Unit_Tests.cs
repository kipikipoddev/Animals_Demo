namespace Animals_Data_Tests;

[TestFixture]
public abstract class Base_Unit_Tests
{
    private string last_message = string.Empty;
    private const string Name = "test";
    protected Data Subject;

    [SetUp]
    public virtual void SetUp()
    {
        last_message = string.Empty;
        Subject = Get_Subject();
    }

    protected void Verify(Printed_Actions action) =>
        Verify_Message($"The {Name} is {action.ToString().ToLower()}");

    protected void Verify_Message(string message) => Assert.That(last_message, Is.EqualTo(message));

    protected void Verify_Never() => Assert.That(last_message, Is.Empty);

    protected virtual Data Get_Subject() =>
        new Data().Add(new Name_Data(Name)).Add(new Print_Action_Data(m => last_message = m));
}
