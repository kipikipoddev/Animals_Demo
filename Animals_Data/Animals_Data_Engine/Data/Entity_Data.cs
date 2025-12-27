namespace Animals_Data_Engine;

public record Entity_Data : Data
{
    public string Name { get; }

    public Entity_Data(string name)
    {
        Name = name.ToLower().Replace('_', ' ');
    }
}
