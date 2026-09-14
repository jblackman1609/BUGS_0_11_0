using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Bugs
{
    public static class AppConfig
    {
        public static AppSettings Settings { get; set; } = new AppSettings();

        public static void Initialize()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            Settings = config.GetSection("AppSettings").Get<AppSettings>() ?? new AppSettings();
        }
    }

    public class AppSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
    }
}

