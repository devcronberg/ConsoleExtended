using Microsoft.Extensions.Configuration;

namespace TemplateNamespace;
internal class ConfigurationHelper
{    
    internal static AppSettings Initialize()
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();

        var appSettings = new AppSettings();
        configuration.Bind("AppSettings", appSettings);
        return appSettings;

    }
}