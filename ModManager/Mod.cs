namespace MonBazou_ModManager;

internal class Mod
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public string ModVersion { get; protected set; }
    public string GameVersion { get; protected set; }
    public string Type { get; protected set; }
    public string Category { get; protected set; }
    public string DllName { get; protected set; }
    public string ZipName { get; protected set; }
    public bool Deactivated { get; protected set; }
    public string Reason { get; protected set; }
}