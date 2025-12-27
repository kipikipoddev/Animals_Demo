namespace Animals_Data_Game;

[GlobalClass]
public partial class Walk_Resource : Data_Resource
{
    [Export]
    public int Legs_Count { get; set; }

    public override Data Get_Data() => new Walk_Data(Legs_Count);
}
