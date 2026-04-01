namespace Animals_Data_Tests;

[TestFixture]
public class Swim_Message_Unit_Tests : Base_Unit_Tests
{
    [Test]
    public void Test_Swim_Invalid_Without_Swim_Data()
    {
        new Swim_Message(Subject).Assert_Invalid();
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Add(new Swim_Data());

        new Swim_Message(Subject).Send().Assert_True();

        Verify(Printed_Actions.Swimming);
    }
}
