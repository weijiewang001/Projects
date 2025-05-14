
using System;
using Serilog;


class Program
{
  static void Main()
  {
    Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
    Log.Information("Hello.Serilog!");
    Log.Warning("This is a warning message!");
    Log.Information("An error occurred!");

    Log.CloseAndFlush();

  }
}