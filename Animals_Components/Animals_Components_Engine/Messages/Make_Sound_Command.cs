namespace Animals_Components_Engine;

public record Make_Sound_Command(Entity_Component Entity) : Action_Command(Entity);
