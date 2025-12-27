namespace Animals_Components_Core;

public record Command(Component Component) : Message(Component);
