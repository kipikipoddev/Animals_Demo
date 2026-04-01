namespace Animals_Components_Engine;

public static class IComponent_Extensions
{
    extension(IComponent component)
    {
        public void Add(IComponent child)
        {
            child.Parent = component;
            component.Children.Add(child);
        }

        public T? Child_Or_Default<T>() => component.Children.OfType<T>().FirstOrDefault();

        public T Child<T>() => component.Child_Or_Default<T>()!;
    }
}
