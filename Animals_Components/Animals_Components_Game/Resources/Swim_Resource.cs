namespace Animals_Component_Game;

[GlobalClass]
public partial class Swim_Resource : Component_Resource
{
    public override Component Get_Component() => new Swim_Component();
}
