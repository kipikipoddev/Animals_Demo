namespace Animals_Data_Core;

public static class Data_Extensions
{
    extension<T>(T parent)
        where T : Data
    {
        public T Add(Data data)
        {
            parent.Children.Add(data);
            return parent;
        }
    }

    extension(Data data)
    {
        public T Child<T>()
            where T : Data => data.Children<T>().First();

        public T? ChildOrDefault<T>()
            where T : Data => data.Children<T>().FirstOrDefault();

        public bool Has_Child<T>() => data.Has_Child(typeof(T));

        public bool Has_Child(Type type) =>
            data.Children.Any(c => c.GetType().IsAssignableTo(type));

        public IEnumerable<T> Children<T>()
            where T : Data => data.Children.OfType<T>();
    }
}
