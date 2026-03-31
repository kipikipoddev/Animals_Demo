namespace Animals_OOP_Tests;

[TestFixture]
public class Robot_Dog_Unit_Tests : Base_Unit_Tests
{
    private Robot_Dog subject;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        subject = new Robot_Dog(Printer);
    }

    [Test]
    public void Robot_Dog_Swim()
    {
        subject.Swim();

        Verify_Never();
    }

    [Test]
    public void Robot_Dog_Swim_Charged()
    {
        subject.Charge();

        subject.Swim();

        Verify(Printed_Actions.Swimming);
        Assert.That(subject.Is_Charged, Is.False);
    }

    [Test]
    public void Robot_Dog_Make_Sound()
    {
        subject.Make_Sound();

        Verify_Never();
    }

    [Test]
    public void Robot_Dog_Make_Sound_Charged()
    {
        subject.Charge();

        subject.Make_Sound();

        Verify(Printed_Actions.Woof);
        Assert.That(subject.Is_Charged, Is.False);
    }

    [Test]
    public void Robot_Dog_Charge()
    {
        subject.Charge();

        Verify(Printed_Actions.Charging);
    }

    [Test]
    public void Robot_Dog_Charge_Charged()
    {
        subject.Charge();
        subject.Charge();

        Verify(Printed_Actions.Charging);
    }
}
