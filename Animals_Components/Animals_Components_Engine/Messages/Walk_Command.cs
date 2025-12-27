namespace Animals_Components_Engine;

public record Walk_Command(Entity_Component Entity) : Command(Entity);
