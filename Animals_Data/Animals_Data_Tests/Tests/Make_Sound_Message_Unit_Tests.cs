namespace Animals_Data_Tests;

[TestFixture]
public class Make_Sound_Message_Unit_Tests : Base_Unit_Tests
{
    [Test]
    public void Test_Make_Sound_Invalid_Without_Sound_Data()
    {
        new Make_Sound_Message(Subject).Assert_Invalid();
    }

    [TestCase(Printed_Actions.Meowing)]
    [TestCase(Printed_Actions.Beeping)]
    [TestCase(Printed_Actions.Barking)]
    public void Test_Make_Sound(Printed_Actions action)
    {
        Subject.Add(new Sound_Data(action));

        new Make_Sound_Message(Subject).Send().Assert_True();

        Verify(action);
    }
}
