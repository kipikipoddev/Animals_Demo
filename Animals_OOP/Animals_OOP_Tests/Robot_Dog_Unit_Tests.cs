namespace Animals_OOP_Tests;

[TestFixture]
public class Robot_Dog_Unit_Tests : Base_Unit_Tests<Robot_Dog>
{
    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        Subject = new Robot_Dog(Printer);
    }

    [Test]
    public void Robot_Dog_Swim()
    {
        Subject.Swim();

        Verify_Never();
    }

    [Test]
    public void Robot_Dog_Swim_Charged()
    {
        Subject.Charge();

        Subject.Swim();

        Verify(Printed_Actions.Swimming);
        Assert.That(Subject.Is_Charged, Is.False);
    }

    [Test]
    public void Robot_Dog_Make_Sound()
    {
        Subject.Make_Sound();

        Verify_Never();
    }

    [Test]
    public void Robot_Dog_Make_Sound_Charged()
    {
        Subject.Charge();

        Subject.Make_Sound();

        Verify(Printed_Actions.Barking);
        Assert.That(Subject.Is_Charged, Is.False);
    }

    [Test]
    public void Robot_Dog_Charge()
    {
        Subject.Charge();

        Verify(Printed_Actions.Charging);
    }

    [Test]
    public void Robot_Dog_Charge_Charged()
    {
        Subject.Charge();
        Subject.Charge();

        Verify(Printed_Actions.Charging);
    }
}
