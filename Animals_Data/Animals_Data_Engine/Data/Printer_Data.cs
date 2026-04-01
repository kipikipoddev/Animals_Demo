namespace Animals_Data_Engine;

public record Printer_Data(Action<string> Write) : Data;
