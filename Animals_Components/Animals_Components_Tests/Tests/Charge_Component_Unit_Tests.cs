namespace Animals_Components_Tests;

[TestFixture]
public class Charge_Component_Unit_Tests : Entity_Unit_Tests<Charge_Component>
{
    [Test]
    public void Test_Charge()
    {
        Component.Charge();

        Verify(Printed_Actions.Charging);
        Component.Is_Charged.Assert_True();
    }

    protected override Charge_Component Get_Component() => new();
}
