public class Fish : Entity, ISwim
{
    public bool Can_Swim => true;

    public void Swim() => Print(Printed_Actions.Swimming);
}
