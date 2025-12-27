namespace Animals_Components_Core;

public static class Assert_Extensions
{
    public static void Assert_False(this bool value)
    {
        Assert.That(value, Is.False);
    }

    public static void Assert_True(this bool value)
    {
        Assert.That(value, Is.True);
    }

    public static void Assert_Invalid(this Message message) => message.Is_Valid().Assert_False();
}
