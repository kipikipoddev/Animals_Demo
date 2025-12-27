namespace Animals_Components_Tests;

[TestFixture]
public class Unit_Tests : Test_Base<Entity_Component>
{
    [Test]
    public void Test_Charge()
    {
        Subject.Add(new Charge_Component());
        new Charge_Command(Subject).Send();
    }

    [Test]
    public void Assert_Charge_Without_Charge_Component()
    {
        new Charge_Command(Subject).Assert_Invalid();
    }

    [Test]
    public void Assert_Charge_Invalid_When_Already_Charged()
    {
        Subject.Add(new Charge_Component(true));
        new Charge_Command(Subject).Assert_Invalid();
    }

    [Test]
    public void Test_Make_Sound()
    {
        Subject.Add(new Sound_Component(nameof(Sound_Component)));
        new Make_Sound_Command(Subject).Send();
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Add(new Walk_Component(2));
        new Walk_Command(Subject).Send();
    }

    [Test]
    public void Assert_Walk_Invalid_When_Uncharged()
    {
        Subject.Add(new Walk_Component(2)).Add(new Charge_Component());
        new Walk_Command(Subject).Assert_Invalid();
    }

    [Test]
    public void Test_Walk_When_Charged()
    {
        Subject.Add(new Walk_Component(2)).Add(new Charge_Component(true));
        new Walk_Command(Subject).Send();
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Add(new Swim_Component());
        new Swim_Command(Subject).Send();
    }

    [Test]
    public void Assert_Swim_Invalid_Without_Swim_Component()
    {
        new Swim_Command(Subject).Assert_Invalid();
    }

    protected override Entity_Component Get_Subject() =>
        new Entity_Component(nameof(Subject)).Add(new Message_Component());
}
