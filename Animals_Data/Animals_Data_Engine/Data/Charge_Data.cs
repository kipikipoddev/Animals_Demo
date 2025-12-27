namespace Animals_Data_Engine;

public record Charge_Data : Data
{
    public bool Is_Charged { get; set; }

    public Charge_Data(bool is_charged = false)
    {
        Is_Charged = is_charged;
    }
}
