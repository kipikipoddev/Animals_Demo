namespace Animals_Data_Game;

public static class Load_Entities_Request_Handler
{
    private static readonly string Path = ".\\Resource_Files\\";
    private const string Suffix = "*.tres";

    [Handler<Load_Entities_Request>]
    public static Entity_Data[] Handle()
    {
        return Directory
            .GetFiles(Path, Suffix, SearchOption.AllDirectories)
            .Select(GD.Load<Entity_Resource>)
            .Select(r => (Entity_Data)r.Map())
            .ToArray();
    }
}
