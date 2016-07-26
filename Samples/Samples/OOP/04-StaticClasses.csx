using System;

//Console.WriteLine("Hello");

public static class Logger
{
    public static readonly string ErrorLabel = "ERROR";
    public static readonly string WarningLabel = "WARNING";
    public static readonly string InfoLabel = "INFO";

    private static void WriteMessage(string severity, string message)

    {
        Console.WriteLine($"[{severity} - {DateTime.UtcNow:O}]{message}");
    }

    public static void LogError(string message)
    {
        WriteMessage(ErrorLabel, message);
    }

    public static void LogWarning(string message)
    {
        WriteMessage(WarningLabel, message);
    }


    public static void LogInfo(string message)
    {
        WriteMessage(InfoLabel, message);
    }
}

Logger.LogError("Somthing's broken");
Logger.LogWarning("Somthing might be broken");
Logger.LogInfo("Somthing's happened");





