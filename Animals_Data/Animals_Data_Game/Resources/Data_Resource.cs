namespace Animals_Data_Game;

[GlobalClass]
public partial class Data_Resource : Resource
{
    [Export]
    public Data_Resource[] Data_Resources;

    public Data Map()
    {
        var data = Get_Data();
        foreach (var data_resource in Data_Resources)
            data.Add(data_resource.Map());
        return data;
    }

    public virtual Data Get_Data() => new Data();
}
