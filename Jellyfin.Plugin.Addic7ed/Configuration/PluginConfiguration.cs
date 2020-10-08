
using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.Addic7ed.Configuration
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
