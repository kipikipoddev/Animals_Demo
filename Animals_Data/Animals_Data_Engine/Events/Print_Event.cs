namespace Animals_Data_Engine;

public record Print_Event(Entity_Data Entity, string Message) : Event;
