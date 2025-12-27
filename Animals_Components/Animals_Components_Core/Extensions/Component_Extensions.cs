namespace Animals_Components_Core;

public static class Component_Extensions
{
    extension<T>(T parent)
        where T : Component
    {
        public T Add(Component component)
        {
            parent.Children.Add(component);
            return parent;
        }
    }

    extension(Component component)
    {
        public T Child<T>()
            where T : Component => component.Children<T>().First();

        public IEnumerable<T> Children<T>() => component.Children.OfType<T>();

        public void Add(IEnumerable<Component> components)
        {
            foreach (var c in components)
                component.Add(c);
        }
    }
}
