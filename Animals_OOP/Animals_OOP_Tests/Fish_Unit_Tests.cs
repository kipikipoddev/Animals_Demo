namespace Animals_OOP_Tests;

[TestFixture]
public class Fish_Unit_Tests : Base_Unit_Tests
{
    private Fish subject;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        subject = new Fish(Printer);
    }

    [Test]
    public void Fish_Swim()
    {
        subject.Swim();

        Verify(Printed_Actions.Swimming);
    }
}
