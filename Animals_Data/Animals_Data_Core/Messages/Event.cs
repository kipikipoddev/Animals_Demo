namespace Animals_Data_Core;

public record Event : Message
{
    public Event() => this.Send();
}
