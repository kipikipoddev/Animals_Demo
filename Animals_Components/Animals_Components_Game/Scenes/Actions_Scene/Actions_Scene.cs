public partial class Actions_Scene : Control
{
    private Button walk_button;
    private Button swim_button;
    private Button charge_button;
    private Button make_sound_button;

    public Entity_Component Entity
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
        walk_button = GetNode<Button>("%Walk_Button");
        swim_button = GetNode<Button>("%Swim_Button");
        charge_button = GetNode<Button>("%Charge_Button");
        make_sound_button = GetNode<Button>("%Make_Sound_Button");
    }

    public void On_Walk_Button_Pressed()
    {
        new Walk_Command(Entity).Send();
        Update();
    }

    public void On_Swim_Button_Pressed()
    {
        new Swim_Command(Entity).Send();
        Update();
    }

    public void On_Charge_Button_Pressed()
    {
        new Charge_Command(Entity).Send();
        Update();
    }

    public void On_Make_Sound_Button_Pressed()
    {
        new Make_Sound_Command(Entity).Send();
        Update();
    }

    private void Set_Visibility()
    {
        walk_button.Visible = Entity.Has_Child<Walk_Component>();
        swim_button.Visible = Entity.Has_Child<Swim_Component>();
        charge_button.Visible = Entity.Has_Child<Charge_Component>();
        make_sound_button.Visible = Entity.Has_Child<Sound_Component>();
    }

    private void Update()
    {
        walk_button.Disabled = new Walk_Command(Entity).Is_Invalid();
        swim_button.Disabled = new Swim_Command(Entity).Is_Invalid();
        charge_button.Disabled = new Charge_Command(Entity).Is_Invalid();
        make_sound_button.Disabled = new Make_Sound_Command(Entity).Is_Invalid();
    }
}
