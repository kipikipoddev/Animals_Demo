using Animals_Component_Game;

namespace Animals_Data_Game;

public partial class Main_Scene : Control
{
    [Export]
    public Entity_Resource[] Entities;

    private ItemList item_list;
    private Label actions_label;
    private Actions_Scene actions_scene;
    private Sprite2D sprite_2d;
    private Entity_Component[] entities;

    public override void _Ready()
    {
        Get_Nodes();

        Add_Entites();

        item_list.Select(0);
        On_Item_Selected(0);

        foreach (var component in entities)
            component.Add_Listner<Print_Event>(Handle);
    }

    public void On_Item_Selected(int index)
    {
        var name = item_list.GetItemText(index);
        actions_scene.Entity = entities.First(c => c.Name == name);
        actions_label.Text = string.Empty;
        sprite_2d.Frame = actions_scene.Entity.Child<Sprite_Component>().Frame;
    }

    public void Handle(Print_Event e)
    {
        actions_label.Text += e.Message + '\n';
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
        entities = Entities.Select(e => (Entity_Component)e.Map()).ToArray();
        foreach (var entity in entities)
            item_list.AddItem(entity.Name);
    }
}
