public class Robot_Dog : Robot, ISwim
{
    private readonly Dog dog;
    protected override int Leg_Count => 4;

    public Robot_Dog(IPrinter printer)
        : base(nameof(Robot_Dog), printer)
    {
        dog = new(nameof(Robot_Dog), printer);
    }

    public override void Make_Sound()
    {
        if (Can_Make_Sound)
            Print("Bark!");
        Is_Charged = false;
    }

    public void Swim()
    {
        if (Can_Swim)
            dog.Swim();
        Is_Charged = false;
    }

    public bool Can_Swim => Is_Charged;
}
