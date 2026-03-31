namespace Animals_Components_Tests;

[TestFixture]
public class Sound_Component_Unit_Tests : Base_Unit_Tests<Sound_Component>
{
    [Test]
    public void Test_Sound()
    {
        Component.Make_Sound();

        Verify(Printed_Actions.Meowing);
    }

    [Test]
    public void Test_Cant_Sound_If_Not_Charged()
    {
        Subject.Add(new Charge_Component());
        Component.Can_Make_Sound.Assert_False();

        Component.Make_Sound();

        Verify_Never();
    }

    [Test]
    public void Test_Sound_If_Charged()
    {
        Subject.Add(new Charge_Component());
        Subject.Child<ICharge_Component>().Charge();

        Component.Make_Sound();

        Verify(Printed_Actions.Meowing);
        Subject.Child<ICharge_Component>().Is_Charged.Assert_False();
    }

    protected override Sound_Component Get_Component() => new(Printed_Actions.Meowing);
}
