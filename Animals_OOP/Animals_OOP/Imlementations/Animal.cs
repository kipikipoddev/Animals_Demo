public abstract class Animal(string name, IPrinter printer) : Entity(name, printer), IAnimal
{
    protected virtual int Leg_Count => 4;

    public virtual bool Can_Make_Sound => true;

    public virtual bool Can_Walk => true;

    public abstract void Make_Sound();

    public virtual void Walk()
    {
        if (Can_Walk)
            Print("The {0} is walking on " + Leg_Count + " legs.");
    }
}
