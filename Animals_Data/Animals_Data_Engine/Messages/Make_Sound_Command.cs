namespace Animals_Data_Engine;

public record Make_Sound_Command(Entity_Data Entity) : Action_Command(Entity);
