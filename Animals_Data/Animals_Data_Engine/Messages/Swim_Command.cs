namespace Animals_Data_Engine;

public record Swim_Command(Entity_Data Entity) : Action_Command(Entity);
