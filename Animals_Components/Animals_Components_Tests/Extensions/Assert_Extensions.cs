namespace Animals_Components_Tests;

public static class Assert_Extensions
{
    public static void Assert_False(this bool value) => Assert.That(value, Is.False);

    public static void Assert_True(this bool value) => Assert.That(value, Is.True);
}
