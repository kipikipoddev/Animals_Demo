namespace Animals_Components_Engine;

public static class Entity_Component_Extensions
{
    extension(Entity_Component entity)
    {
        public void Print(string message) =>
            new Print_Event(entity, string.Format(message, entity.Name)).Send();
    }
}
