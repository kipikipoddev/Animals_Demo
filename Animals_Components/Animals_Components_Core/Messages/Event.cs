namespace Animals_Components_Core;

public record Event(Component Component) : Message(Component);
