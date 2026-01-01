namespace Animals_Components_Engine;

public record Swim_Command(Entity_Component Entity) : Action_Command(Entity);
