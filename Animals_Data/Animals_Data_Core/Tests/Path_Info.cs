namespace Animals_Data_Core;

internal class Path_Info
{
    private const string Tests_Folder_Path = @".\..\..\..\Tests_Files\{0}.json";
    public string Path { get; }

    private static TestContext.TestAdapter Test => TestContext.CurrentContext.Test;

    public Path_Info()
    {
        Path = string.Format(Tests_Folder_Path, Get_Prefix());
    }

    private static string Get_Prefix()
    {
        var prefix = $"{Test.DisplayName}\\{Test.MethodName}";
        return Add_Case_To_Prefix(prefix);
    }

    private static string Add_Case_To_Prefix(string prefix)
    {
        if (Test.Arguments.Length == 0)
            return prefix;
        var cases = string.Join(',', Test.Arguments.Select(arg => arg!.ToString()));
        return $"{prefix} ({cases})";
    }
}
