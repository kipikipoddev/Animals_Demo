namespace Animals_Components_Core;

public static class Component_Extensions
{
    public static T Add<T>(this T component, Component child)
        where T : Component
    {
        component.Add_Child(child);
        return component;
    }

    extension(Component component)
    {
        public T Child<T>()
            where T : Component => component.ChildOrDefault<T>()!;

        public T? ChildOrDefault<T>()
            where T : Component => component.Children<T>().FirstOrDefault();

        public bool Has_Child<T>()
            where T : Component => component.ChildOrDefault<T>() != null;

        public IEnumerable<T> Children<T>() => component.Children.OfType<T>();

        public void Add(IEnumerable<Component> components)
        {
            foreach (var c in components)
                Add(component, c);
        }
    }
}
