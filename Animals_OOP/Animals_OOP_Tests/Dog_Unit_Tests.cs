namespace Animals_OOP_Tests;

[TestFixture]
public class Dog_Unit_Tests : Base_Unit_Tests<Dog>
{
    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        Subject = new Dog(Printer);
    }

    [Test]
    public void Dog_Swim()
    {
        Subject.Swim();

        Verify(Printed_Actions.Swimming);
    }

    [Test]
    public void Dog_Make_Sound()
    {
        Subject.Make_Sound();

        Verify(Printed_Actions.Barking);
    }
}
