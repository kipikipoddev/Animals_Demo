namespace Animals_Data_Game;

[GlobalClass]
public partial class Entity_Resource : Data_Resource
{
    [Export]
    public string Name { get; set; }

    public override Data Get_Data() => new Data().Add(new Name_Data(Name));
}
