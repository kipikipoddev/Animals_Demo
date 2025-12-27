namespace Animals_Data_Game;

public static class Load_Data_Request_Handler
{
    private static readonly string Path = ".\\Resource_Files\\";
    private const string Suffix = "*.tres";

    [Handler<Load_Data_Request>]
    public static Data[] Handle()
    {
        return Directory
            .GetFiles(Path, Suffix, SearchOption.AllDirectories)
            .Select(GD.Load<Data_Resource>)
            .Select(r => r.Map())
            .ToArray();
    }
}
