using MediaBrowser.Model.Plugins;

public class PluginConfiguration : BasePluginConfiguration
{
    public string ApiKey { get; set; }
    public string Languages { get; set; } = "en";
}
