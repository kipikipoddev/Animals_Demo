namespace Animals_Data_Game;

public partial class Main_Scene : Control, IListener<Print_Event>
{
    private Dictionary<string, Entity_Data> name_to_data;

    private ItemList item_list;
    private Label actions_label;
    private Actions_Scene actions_scene;
    private Sprite2D sprite_2d;

    public override void _Ready()
    {
        Get_Nodes();

        Add_Entites();

        item_list.Select(0);
        On_Item_Selected(0);

        this.Add_Listener();
    }

    public void On_Item_Selected(int index)
    {
        var name = item_list.GetItemText(index);
        actions_scene.Data = name_to_data[name];
        actions_label.Text = string.Empty;
        sprite_2d.Frame = actions_scene.Data.Child<Sprite_Data>().Frame;
    }

    public void On_Event(Print_Event e)
    {
        actions_label.Text += string.Format(e.Message, e.Entity.Name) + '\n';
    }

    private void Get_Nodes()
    {
        item_list = GetNode<ItemList>("%ItemList");
        actions_label = GetNode<Label>("%Actions_Label");
        actions_scene = GetNode<Actions_Scene>("%Actions_Scene");
        sprite_2d = GetNode<Sprite2D>("%Sprite2D");
    }

    private void Add_Entites()
    {
        var entities = new Load_Entities_Request().Send() as Entity_Data[];
        name_to_data = entities.ToDictionary(d => d.Name);
        foreach (var name in name_to_data.Keys)
            item_list.AddItem(name);
    }
}
