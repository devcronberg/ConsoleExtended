using Microsoft.Extensions.Configuration;
using Serilog;
namespace TemplateNamespace;
internal class LogHelper
{

    internal static ILogger Initialize()
    {
        var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();
        return Log.Logger;
    }
}