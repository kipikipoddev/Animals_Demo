public class Dog : Entity, ISound, ISwim
{
    public bool Can_Make_Sound => true;

    public bool Can_Swim => true;

    public void Make_Sound() => Print(Printed_Actions.Barking);

    public void Swim() => Print(Printed_Actions.Swimming);
}
