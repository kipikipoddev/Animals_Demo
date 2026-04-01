public partial class Actions_Scene : Control
{
    private Button swim_button;
    private Button charge_button;
    private Button make_sound_button;

    public Entity_Data Data
    {
        get;
        set
        {
            field = value;
            Set_Visibility();
            Update();
        }
    }

    public override void _Ready()
    {
        swim_button = GetNode<Button>("%Swim_Button");
        charge_button = GetNode<Button>("%Charge_Button");
        make_sound_button = GetNode<Button>("%Make_Sound_Button");
    }

    public void On_Swim_Button_Pressed()
    {
        new Swim_Message(Data).Send();
        Update();
    }

    public void On_Charge_Button_Pressed()
    {
        new Charge_Message(Data).Send();
        Update();
    }

    public void On_Make_Sound_Button_Pressed()
    {
        new Make_Sound_Message(Data).Send();
        Update();
    }

    private void Set_Visibility()
    {
        swim_button.Visible = Data.Has_Child<Swim_Data>();
        charge_button.Visible = Data.Has_Child<Charge_Data>();
        make_sound_button.Visible = Data.Has_Child<Sound_Data>();
    }

    private void Update()
    {
        swim_button.Disabled = new Swim_Message(Data).Is_Invalid();
        charge_button.Disabled = new Charge_Message(Data).Is_Invalid();
        make_sound_button.Disabled = new Make_Sound_Message(Data).Is_Invalid();
    }
}
