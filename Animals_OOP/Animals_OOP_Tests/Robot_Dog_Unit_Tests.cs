namespace Animals_OOP_Tests;

[TestFixture]
public class Robot_Dog_Unit_Tests : Base_Unit_Tests<Robot_Dog>
{
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

        Verify("The robot dog is swimming");
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

        Verify("The robot dog is barking");
        Assert.That(Subject.Is_Charged, Is.False);
    }

    [Test]
    public void Robot_Dog_Charge()
    {
        Subject.Charge();

        Verify("The robot dog is charging");
        Assert.That(Subject.Is_Charged, Is.True);
    }

    [Test]
    public void Robot_Dog_Charge_Charged()
    {
        Subject.Charge();
        Subject.Charge();

        Verify("The robot dog is charging");
    }
}
