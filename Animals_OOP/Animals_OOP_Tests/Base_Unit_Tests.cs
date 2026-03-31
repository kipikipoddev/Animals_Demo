namespace Animals_OOP_Tests;

[TestFixture]
public class Base_Unit_Tests<T>
{
    protected T Subject;
    private StringWriter sw;

    [SetUp]
    public void SetUp()
    {
        sw = new StringWriter();
        Console.SetOut(sw);
        Subject = Activator.CreateInstance<T>();
    }

    [TearDown]
    public void TearDown() => sw.Dispose();

    protected void Verify_Never() => Assert.That(sw.ToString(), Is.EqualTo(string.Empty));

    protected void Verify(string message) => Assert.That(Last_Printed, Is.EqualTo(message));

    private string Last_Printed => sw.ToString().Split("\r\n")[^2];
}
