namespace Animals_OOP_Tests;

[TestFixture]
public class Dog_Unit_Tests : Base_Unit_Tests
{
    private Dog subject;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        subject = new Dog(Printer);
    }

    [Test]
    public void Dog_Swim()
    {
        subject.Swim();

        Verify(Printed_Actions.Swimming);
    }

    [Test]
    public void Dog_Make_Sound()
    {
        subject.Make_Sound();

        Verify(Printed_Actions.Woof);
    }
}
