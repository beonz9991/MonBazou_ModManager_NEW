namespace MonBazou_ModManager;

internal class Mod
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ModVersion { get; set; }
    public string GameVersion { get; set; }
    public string Type { get; set; }
    public string Category { get; set; }
    public string DllName { get; set; }
    public string ZipName { get; set; }
    public bool Deactivated { get; set; }
    public string Reason { get; set; }
}