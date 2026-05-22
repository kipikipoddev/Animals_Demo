namespace Animals_Data_Engine;

public record Print_Action_Command(Entity_Data Data, Printed_Actions Action) : Command;
