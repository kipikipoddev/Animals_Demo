namespace Animals_OOP_Tests;

[TestFixture]
public class Cat_Unit_Tests : Base_Unit_Tests<Cat>
{
    [Test]
    public void Cat_Make_Sound()
    {
        Subject.Make_Sound();

        Verify("The cat is meowing");
    }
}
