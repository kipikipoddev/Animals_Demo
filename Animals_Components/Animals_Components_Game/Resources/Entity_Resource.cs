namespace Animals_Component_Game;

[GlobalClass]
public partial class Entity_Resource : Component_Resource
{
    [Export]
    public string Name { get; set; }

    public override Component Get_Component() => new Entity_Component(Name);
}
