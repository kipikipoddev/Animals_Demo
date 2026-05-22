namespace Animals_Data_Tests;

[TestFixture]
public class Action_Command_Unit_Tests : Base_Unit_Tests
{
    [SetUp]
    public override void SetUp()
    {
        base.SetUp();
        Subject.Add(new Sound_Data(Printed_Actions.Meowing)).Add(new Charge_Data());
    }

    [Test]
    public void Test_Action_Command_Invalid_When_Uncharged()
    {
        new Make_Sound_Command(Subject).Assert_Invalid();
    }

    [Test]
    public void Test_Action_Command_When_Charged()
    {
        new Charge_Command(Subject).Send();

        new Make_Sound_Command(Subject).Send().Assert_True();

        Verify(Printed_Actions.Meowing);
        Subject.Child<Charge_Data>().Is_Charged.Assert_False();
    }
}
