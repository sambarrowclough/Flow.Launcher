using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Flow.Launcher.Infrastructure
{
    public static class Constant
    {
        public const string FlowLauncher = "Flow.Launcher";
        public const string Plugins = "Plugins";
        public const string PluginMetadataFileName = "plugin.json";

        public const string ApplicationFileName = FlowLauncher + ".exe";

        private static readonly Assembly Assembly = Assembly.GetExecutingAssembly();
        public static readonly string ProgramDirectory = Directory.GetParent(Assembly.Location.NonNull()).ToString();
        public static readonly string ExecutablePath = Path.Combine(ProgramDirectory, FlowLauncher + ".exe");
        public static readonly string ApplicationDirectory = Directory.GetParent(ProgramDirectory).ToString();
        public static readonly string RootDirectory = Directory.GetParent(ApplicationDirectory).ToString();
        
        public static readonly string PreinstalledDirectory = Path.Combine(ProgramDirectory, Plugins);
        public const string Issue = "https://github.com/Flow-Launcher/Flow.Launcher/issues/new";
        public static readonly string Version = FileVersionInfo.GetVersionInfo(Assembly.Location.NonNull()).ProductVersion;

        public static readonly int ThumbnailSize = 64;
        public static readonly string DefaultIcon = Path.Combine(ProgramDirectory, "Images", "app.png");
        public static readonly string ErrorIcon = Path.Combine(ProgramDirectory, "Images", "app_error.png");

        public static string PythonPath;

        public static readonly string QueryTextBoxIconImagePath = $"{ProgramDirectory}\\Images\\mainsearch.png";

        public const string DefaultTheme = "Darker";
    }
}
