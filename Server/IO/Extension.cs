namespace IO;

public static class Extension
{
    public static string ConnectionString() {
       var Sys = System.Environment.GetFolderPath(System.Environment.SpecialFolder.System);
       if (!File.Exists($"{Sys}/OSICI.Database"))
            File.CreateText($"{Sys}/OSICI.Database").Write("Database");
        return File.ReadAllText($"{Sys}/OSICI.Database");
    }
}