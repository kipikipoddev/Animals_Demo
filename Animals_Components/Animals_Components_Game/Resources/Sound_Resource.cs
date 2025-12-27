namespace Animals_Component_Game;

[GlobalClass]
public partial class Sound_Resource : Component_Resource
{
    [Export]
    public string Sound { get; set; }

    public override Component Get_Component() => new Sound_Component(Sound);
}
