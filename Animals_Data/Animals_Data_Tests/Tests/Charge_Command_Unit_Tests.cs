using NUnit.Framework.Internal;

namespace Animals_Data_Tests;

[TestFixture]
public class Charge_Command_Unit_Tests : Base_Unit_Tests
{
    [Test]
    public void Test_Charge_Without_Charge_Data()
    {
        new Charge_Command(Subject).Assert_Invalid();
    }

    [Test]
    public void Test_Charge()
    {
        Subject.Add(new Charge_Data());

        new Charge_Command(Subject).Send().Assert_True();

        Verify(Printed_Actions.Charging);
        Subject.Child<Charge_Data>().Is_Charged.Assert_True();
    }
}
