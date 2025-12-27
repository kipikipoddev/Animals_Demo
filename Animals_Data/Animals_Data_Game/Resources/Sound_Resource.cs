namespace Animals_Data_Game;

[GlobalClass]
public partial class Sound_Resource : Data_Resource
{
    [Export]
    public string Sound { get; set; }

    public override Data Get_Data() => new Sound_Data(Sound);
}
