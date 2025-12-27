namespace Animals_Components_Tests;

public record class Message_Component : Component, IHandler<Print_Event>
{
    public List<string> Messages { get; } = [];

    public void Handle(Print_Event cmd) => Messages.Add(cmd.Message);
}
