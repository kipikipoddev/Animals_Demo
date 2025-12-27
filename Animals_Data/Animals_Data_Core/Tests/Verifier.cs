namespace Animals_Data_Core;

internal static class Verifier
{
    public static void Verify(string json)
    {
        Handle_Expected(json, new Path_Info());
    }

    private static void Handle_Expected(string result, Path_Info path)
    {
        string? context = null;
        if (File.Exists(path.Path))
            context = File.ReadAllText(path.Path);

        Write_File(result, path.Path);

        if (context != null)
            Assert.That(result, Is.EqualTo(context));
    }

    private static void Write_File(string context, string path)
    {
        Directory.CreateDirectory(path[..path.LastIndexOf('\\')]);
        File.WriteAllText(path, context);
    }
}
