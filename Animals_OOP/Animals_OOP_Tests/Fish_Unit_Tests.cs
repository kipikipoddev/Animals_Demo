namespace Animals_OOP_Tests;

[TestFixture]
public class Fish_Unit_Tests : Base_Unit_Tests<Fish>
{
    [Test]
    public void Fish_Swim()
    {
        Subject.Swim();

        Verify("The fish is swimming");
    }
}
