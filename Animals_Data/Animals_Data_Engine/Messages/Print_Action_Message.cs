namespace Animals_Data_Engine;

public record Print_Action_Message(Entity_Data Data, Printed_Actions Action) : Command;
