namespace Animals_Component_Game;

[GlobalClass]
public partial class Charge_Resource : Component_Resource
{
    public override Component Get_Component() => new Charge_Component();
}
