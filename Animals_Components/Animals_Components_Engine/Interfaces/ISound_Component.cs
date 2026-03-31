namespace Animals_Components_Engine;

public interface ISound_Component : IComponent
{
    void Make_Sound();
    bool Can_Make_Sound { get; }
}
