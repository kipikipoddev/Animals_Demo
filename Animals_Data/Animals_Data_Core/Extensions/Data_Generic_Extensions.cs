namespace Animals_Data_Core;

public static class Data_Generic_Extensions
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
}
