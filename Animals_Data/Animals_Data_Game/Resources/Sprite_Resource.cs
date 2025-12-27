namespace Animals_Data_Game;

[GlobalClass]
public partial class Sprite_Resource : Data_Resource
{
    [Export]
    public int Frame { get; set; }

    public override Data Get_Data() => new Sprite_Data(Frame);
}
