namespace Animals_Data_Engine;

public record Swim_Command(Data Data) : Action_Command(Data);
