namespace Animals_OOP_Tests;

[TestFixture]
public class Robot_Unit_Tests : Base_Unit_Tests<Robot>
{
    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        Subject = new Robot(Printer);
    }

    [Test]
    public void Robot_Make_Sound()
    {
        Subject.Make_Sound();

        Verify_Never();
    }

    [Test]
    public void Robot_Make_Sound_Charged()
    {
        Subject.Charge();

        Subject.Make_Sound();

        Verify(Printed_Actions.Beeping);
        Assert.That(Subject.Is_Charged, Is.False);
    }

    [Test]
    public void Robot_Charge()
    {
        Subject.Charge();

        Verify(Printed_Actions.Charging);
    }

    [Test]
    public void Robot_Charge_Charged()
    {
        Subject.Charge();
        Subject.Charge();

        Verify(Printed_Actions.Charging);
    }
}
