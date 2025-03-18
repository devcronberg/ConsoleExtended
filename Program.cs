using Dumpify;
using Serilog;
using Spectre.Console;
using TemplateNamespace;


AppSettings appSettings = ConfigurationHelper.Initialize();
ILogger logger  = LogHelper.Initialize();

Thread.CurrentThread.CurrentCulture =
new System.Globalization.CultureInfo(appSettings.Culture??"en-US");

// Run to see the output and then delete the following lines
// ---------------------------------------------------------
logger.Information("Serilog loaded and enabled (see AppSetting.json)");
logger.Information("AppSettings loaded to a class instance");
logger.Information("Dumpify loaded\r\n");
appSettings.Dump();
AnsiConsole.MarkupLine("[green]Spectre.Console loaded[/]");
        AnsiConsole.Progress()
            .Start(ctx =>
            {
                var task = ctx.AddTask("[green]Working...[/]");
                while (!task.IsFinished)
                {
                    task.Increment(10);
                    Thread.Sleep(150);
                }
            });

        AnsiConsole.MarkupLine("[bold cyan]Done![/]");
// ---------------------------------------------------------

await Task.Delay(100);
Log.CloseAndFlush();
