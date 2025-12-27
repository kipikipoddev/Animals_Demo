namespace Animals_Component_Game;

[GlobalClass]
public partial class Sprite_Resource : Component_Resource
{
    [Export]
    public int Frame { get; set; }

    public override Component Get_Component() => new Sprite_Component(Frame);
}
