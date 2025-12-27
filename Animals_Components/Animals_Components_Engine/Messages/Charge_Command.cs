namespace Animals_Components_Engine;

public record Charge_Command(Entity_Component Entity) : Command(Entity);
