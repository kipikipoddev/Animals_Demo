namespace Animals_Components_Engine;

public record Walk_Component(int Legs_Count) : Component, IHandler<Walk_Command>
{
    public void Handle(Walk_Command cmd)
    {
        cmd.Entity.Print("The {0} is walking on " + Legs_Count + " legs.");
    }
}
