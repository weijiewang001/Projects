
using System;
using Serilog;
using Serilog.Core;


class Program
{
  static void Main()
  {
    Log.Logger = new LoggerConfiguration()
                  .MinimumLevel.Debug()
                  .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Day)
                  .CreateLogger();

    try
    {
      Log.Information("Information message: Before Calculation");
      int zeroVal = 0;
      int result = (10 / zeroVal);
    }
    catch (Exception ex)
    {
      Log.Error("This is an error message!" + ex.Message);
      Environment.Exit(1);
    }
    finally
    {
      Log.CloseAndFlush();
    }




    // Log.Logger = new LoggerConfiguration()
    //         .MinimumLevel.Debug()
    //         .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Day)
    //         .CreateLogger();
    // Log.Information("Hello.Serilog!");
    // Log.Warning("This is a warning message!");
    // Log.Information("An error occurred!");

    // Log.CloseAndFlush();

  }
}