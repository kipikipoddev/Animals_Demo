namespace Animals_Components_Engine;

public record Walk_Command(Entity_Component Entity) : Action_Command(Entity);
