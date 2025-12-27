namespace Animals_Components_Engine;

public record Sound_Component(string Sound) : Component, IHandler<Make_Sound_Command>
{
    public void Handle(Make_Sound_Command cmd)
    {
        cmd.Entity.Print(Sound);
    }
}
