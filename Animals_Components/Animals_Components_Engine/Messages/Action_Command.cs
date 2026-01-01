namespace Animals_Components_Engine;

public record Action_Command(Entity_Component Entity) : Command(Entity);
