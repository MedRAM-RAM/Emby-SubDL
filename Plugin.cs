using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Model.IO;
using System;

public class Plugin : BasePlugin<PluginConfiguration>
{
    public Plugin(IApplicationPaths appPaths, IXmlSerializer xmlSerializer)
        : base(appPaths, xmlSerializer) { }

    public override Guid Id => new Guid("YOUR-GUID-HERE");
    public override string Name => "SubDL Subtitle Provider";
}
