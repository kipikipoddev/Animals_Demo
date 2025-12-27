namespace Animals_Data_Game;

[GlobalClass]
public partial class Charge_Resource : Data_Resource
{
    public override Data Get_Data() => new Charge_Data();
}
