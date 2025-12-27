namespace Animals_Components_Engine;

public record Make_Sound_Command(Entity_Component Entity) : Command(Entity);
