public class Robot_Dog : Robot, ISwim
{
    public bool Can_Swim => Is_Charged;

    public void Swim()
    {
        if (Can_Swim)
            Print("swimming");
    }

    public override void Make_Sound()
    {
        if (Can_Make_Sound)
            Print("barking");
    }
}
