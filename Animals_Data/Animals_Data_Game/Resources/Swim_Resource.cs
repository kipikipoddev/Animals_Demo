namespace Animals_Data_Game;

[GlobalClass]
public partial class Swim_Resource : Data_Resource
{
    public override Data Get_Data() => new Swim_Data();
}
