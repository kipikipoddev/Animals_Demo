namespace Animals_Data_Tests;

[TestFixture]
public class Swim_Command_Unit_Tests : Base_Unit_Tests
{
    [Test]
    public void Test_Swim_Invalid_Without_Swim_Data()
    {
        new Swim_Command(Subject).Assert_Invalid();
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Add(new Swim_Data());

        new Swim_Command(Subject).Send().Assert_True();

        Verify(Printed_Actions.Swimming);
    }
}
