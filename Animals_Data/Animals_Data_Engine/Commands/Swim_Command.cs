namespace Animals_Data_Engine;

public record Swim_Command(Entity_Data Data) : Action_Command(Data);
