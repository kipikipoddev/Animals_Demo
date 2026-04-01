namespace Animals_Data_Game;

public partial class Main_Scene : Control
{
    [Export]
    public Entity_Resource[] Entities;

    private Dictionary<string, Data> name_to_data;

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
        var entities = Entities.Select(e => e.Map()).ToArray();
        foreach (var entity in entities)
            entity.Add(new Print_Action_Data(Print_Message));
        name_to_data = entities.ToDictionary(d => d.Child<Name_Data>().Name);
        foreach (var name in name_to_data.Keys)
            item_list.AddItem(name);
    }

    public void On_Item_Selected(int index)
    {
        var name = item_list.GetItemText(index);
        actions_scene.Data = name_to_data[name];
        actions_label.Text = string.Empty;
        sprite_2d.Frame = actions_scene.Data.Child<Sprite_Data>().Frame;
    }

    private void Print_Message(string message) => actions_label.Text += message + '\n';
}
