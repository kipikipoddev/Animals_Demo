namespace Animals_Components_Tests;

[TestFixture]
public class Swim_Component_Unit_Tests : Base_Unit_Tests<Swim_Component>
{
    [Test]
    public void Test_Swim()
    {
        Component.Swim();

        Verify(Printed_Actions.Swimming);
    }

    [Test]
    public void Test_Cant_Swim_If_Not_Charged()
    {
        Subject.Add(new Charge_Component());
        Component.Can_Swim.Assert_False();

        Component.Swim();

        Verify_Never();
    }

    [Test]
    public void Test_Swim_If_Charged()
    {
        Subject.Add(new Charge_Component(true));

        Component.Swim();

        Verify(Printed_Actions.Swimming);
        Subject.Child<ICharge_Component>().Is_Charged.Assert_False();
    }
}
