public class Cat : Entity, ISound
{
    public bool Can_Make_Sound => true;

    public void Make_Sound() => Print(Printed_Actions.Meowing);
}
