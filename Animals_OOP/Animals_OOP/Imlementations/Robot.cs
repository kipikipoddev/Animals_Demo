public class Robot : Entity, ISound, ICharge
{
    public bool Can_Make_Sound => Is_Charged;

    public bool Is_Charged { get; protected set; }

    public void Charge()
    {
        Print("charging");
        Is_Charged = true;
    }

    public virtual void Make_Sound()
    {
        if (Can_Make_Sound)
            Print("beeping");
    }
}
