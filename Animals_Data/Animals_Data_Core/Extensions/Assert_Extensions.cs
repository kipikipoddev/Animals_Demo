namespace Animals_Data_Core;

public static class Assert_Extensions
{
    public static void Assert_False(this bool value) => Assert.That(value, Is.False);

    public static void Assert_True(this bool value) => Assert.That(value, Is.True);

    public static void Assert_Valid(this Command cmd) => cmd.Is_Valid().Assert_True();

    public static void Assert_Invalid(this Command cmd) => cmd.Is_Valid().Assert_False();
}
