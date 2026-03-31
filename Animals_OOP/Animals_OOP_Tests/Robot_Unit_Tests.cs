namespace Animals_OOP_Tests;

[TestFixture]
public class Robot_Unit_Tests : Base_Unit_Tests<Robot>
{
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

        Verify("The robot is beeping");
        Assert.That(Subject.Is_Charged, Is.False);
    }

    [Test]
    public void Robot_Charge()
    {
        Subject.Charge();

        Verify("The robot is charging");
        Assert.That(Subject.Is_Charged, Is.True);
    }

    [Test]
    public void Robot_Charge_Charged()
    {
        Subject.Charge();
        Subject.Charge();

        Verify("The robot is charging");
    }
}
