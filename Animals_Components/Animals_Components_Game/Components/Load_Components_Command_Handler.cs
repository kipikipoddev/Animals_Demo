namespace Animals_Component_Game;

public record Components_Loader_Component : Component, IHandler<Load_Components_Command>
{
    private static readonly string Path = ".\\Resource_Files\\";
    private const string Suffix = "*.tres";

    public void Handle(Load_Components_Command req)
    {
        req.Component.Add(Get_Components());
    }

    private IEnumerable<Component> Get_Components() =>
        Directory
            .GetFiles(Path, Suffix, SearchOption.AllDirectories)
            .Select(GD.Load<Component_Resource>)
            .Select(r => r.Map());
}
