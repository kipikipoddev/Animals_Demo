namespace Animals_Component_Game;

[GlobalClass]
public partial class Component_Resource : Resource
{
    [Export]
    public Component_Resource[] Data_Resources;

    public Component Map()
    {
        var data = Get_Component();
        foreach (var data_resource in Data_Resources)
            data.Add(data_resource.Map());
        return data;
    }

    public virtual Component Get_Component() => new Component();
}
