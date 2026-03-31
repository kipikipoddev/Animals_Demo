namespace Animals_OOP_Tests;

[TestFixture]
public class Fish_Unit_Tests : Base_Unit_Tests<Fish>
{
    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        Subject = new Fish(Printer);
    }

    [Test]
    public void Fish_Swim()
    {
        Subject.Swim();

        Verify(Printed_Actions.Swimming);
    }
}
