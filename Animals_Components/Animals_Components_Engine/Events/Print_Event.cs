namespace Animals_Components_Engine;

public record Print_Event(Component Component, string Message) : Event(Component);
