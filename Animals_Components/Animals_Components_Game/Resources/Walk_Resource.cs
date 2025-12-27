namespace Animals_Component_Game;

[GlobalClass]
public partial class Walk_Resource : Component_Resource
{
    [Export]
    public int Legs_Count { get; set; }

    public override Component Get_Component() => new Walk_Component(Legs_Count);
}
