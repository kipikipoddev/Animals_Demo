namespace Animals_OOP_Tests;

[TestFixture]
public class Cat_Unit_Tests : Base_Unit_Tests
{
    private Cat subject;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        subject = new Cat(Printer);
    }

    [Test]
    public void Cat_Make_Sound()
    {
        subject.Make_Sound();

        Verify(Printed_Actions.Meow);
    }
}
