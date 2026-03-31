namespace Animals_OOP_Tests;

[TestFixture]
public class Dog_Unit_Tests : Base_Unit_Tests<Dog>
{
    [Test]
    public void Dog_Swim()
    {
        Subject.Swim();

        Verify("The dog is swimming");
    }

    [Test]
    public void Dog_Make_Sound()
    {
        Subject.Make_Sound();

        Verify("The dog is barking");
    }
}
