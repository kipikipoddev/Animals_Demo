namespace Animals_Data_Core;

public abstract class Test_Base<T>
    where T : Data
{
    protected const int Zero = 0;
    protected const int One = 1;
    protected const int Five = 5;
    protected const int Ten = 10;

    protected T Subject;

    private static string Test_Name => TestContext.CurrentContext.Test.MethodName!;

    [SetUp]
    public virtual void Setup()
    {
        Subject = Get_Subject();
    }

    [TearDown]
    public virtual void Tear_Down()
    {
        try
        {
            if (Test_Name.StartsWith(nameof(Assert)).Not())
                Verifier.Verify(Subject.Serialize());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    protected virtual T Get_Subject() => Activator.CreateInstance<T>();
}
