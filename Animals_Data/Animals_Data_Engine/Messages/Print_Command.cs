namespace Animals_Data_Engine;

public record Print_Command(Entity_Data Entity, string Message) : Command;
