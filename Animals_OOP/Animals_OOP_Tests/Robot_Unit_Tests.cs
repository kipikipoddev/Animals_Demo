namespace Animals_OOP_Tests;

[TestFixture]
public class Robot_Unit_Tests : Base_Unit_Tests
{
    private Robot subject;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        subject = new Robot(Printer);
    }

    [Test]
    public void Robot_Make_Sound()
    {
        subject.Make_Sound();

        Verify_Never();
    }

    [Test]
    public void Robot_Make_Sound_Charged()
    {
        subject.Charge();

        subject.Make_Sound();

        Verify(Printed_Actions.Beep);
        Assert.That(subject.Is_Charged, Is.False);
    }

    [Test]
    public void Robot_Charge()
    {
        subject.Charge();

        Verify(Printed_Actions.Charging);
    }

    [Test]
    public void Robot_Charge_Charged()
    {
        subject.Charge();
        subject.Charge();

        Verify(Printed_Actions.Charging);
    }
}
