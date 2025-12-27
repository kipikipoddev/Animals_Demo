namespace Animals_Data_Tests;

[TestFixture]
public class Unit_Tests : Test_Base<Entity_Data>, IListener<Print_Event>
{
    [SetUp]
    public override void Setup()
    {
        base.Setup();
        this.Add_Listener();
    }

    [Test]
    public void Test_Charge()
    {
        Subject.Add(new Charge_Data());
        new Charge_Command(Subject).Send().Assert_True();
    }

    [Test]
    public void Assert_Charge_Invalid_When_Already_Charged()
    {
        Subject.Add(new Charge_Data(true));
        new Charge_Command(Subject).Assert_Invalid();
    }

    [Test]
    public void Test_Make_Sound()
    {
        Subject.Add(new Sound_Data(nameof(Sound_Data)));
        new Make_Sound_Command(Subject).Send().Assert_True();
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Add(new Walk_Data(2));
        new Walk_Command(Subject).Send().Assert_True();
    }

    [Test]
    public void Assert_Walk_Invalid_When_Uncharged()
    {
        Subject.Add(new Walk_Data(2)).Add(new Charge_Data());
        new Walk_Command(Subject).Assert_Invalid();
    }

    [Test]
    public void Test_Walk_When_Charged()
    {
        Subject.Add(new Walk_Data(2)).Add(new Charge_Data(true));
        new Walk_Command(Subject).Send().Assert_True();
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Add(new Swim_Data());
        new Swim_Command(Subject).Send().Assert_True();
    }

    [Test]
    public void Assert_Swim_Invalid_Without_Swim_Data()
    {
        new Swim_Command(Subject).Assert_Invalid();
    }

    [Test]
    public void Assert_Make_Sound_Invalid_Without_Sound_Data()
    {
        new Make_Sound_Command(Subject).Assert_Invalid();
    }

    public void On_Event(Print_Event e)
    {
        e.Entity.Add(new Message_Data(e.Message));
    }

    protected override Entity_Data Get_Subject() => new Entity_Data(nameof(Subject));
}
