namespace Animals_OOP_Tests;

[TestFixture]
public class Cat_Unit_Tests : Base_Unit_Tests<Cat>
{
    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        Subject = new Cat(Printer);
    }

    [Test]
    public void Cat_Make_Sound()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);

        Subject.Make_Sound();
        var output = sw.ToString();
        //Verify(Printed_Actions.Meowing);
    }
}
