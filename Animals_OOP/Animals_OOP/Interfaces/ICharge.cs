public interface ICharge
{
    bool Is_Charged { get; }
    bool Can_Charge { get; }
    void Charge();
}
