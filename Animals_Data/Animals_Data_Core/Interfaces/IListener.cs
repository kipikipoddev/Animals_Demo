namespace Animals_Data_Core;

public interface IListener<T>
    where T : Event
{
    void On_Event(T e);
}
