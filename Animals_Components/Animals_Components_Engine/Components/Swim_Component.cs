namespace Animals_Components_Engine;

public record Swim_Component : Component, IHandler<Swim_Command>
{
    public void Handle(Swim_Command cmd)
    {
        cmd.Entity.Print("The {0} is swimming");
    }
}
