namespace Animals_Data_Tests;

[TestFixture]
public class Action_Message_Unit_Tests : Base_Unit_Tests
{
    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        Subject.Add(new Sound_Data(Printed_Actions.Meowing)).Add(new Charge_Data());
    }

    [Test]
    public void Test_Action_Message_Invalid_When_Uncharged()
    {
        new Make_Sound_Message(Subject).Assert_Invalid();
    }

    [Test]
    public void Test_Action_Message_When_Charged()
    {
        new Charge_Message(Subject).Send();

        new Make_Sound_Message(Subject).Send().Assert_True();

        Verify(Printed_Actions.Meowing);
    }
}
