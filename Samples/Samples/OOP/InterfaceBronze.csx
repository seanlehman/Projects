#r "System.Windows.Forms.dll"

using System;
using System.Windows.Forms;

public interface ILogger
{
    void LowMsg();
    void MedMsg();
    void HighMsg();
}

public class ConsoleLogger : ILogger
{
    public void LowMsg()
    {
        Console.WriteLine("INFO");
    }

    public void MedMsg()
    {
        Console.WriteLine("WARNING");
    }

    public void HighMsg()
    {
        Console.WriteLine("ERROR");
    }
}


var cl = new ConsoleLogger();
cl.LowMsg()
cl.MedMsg()
cl.HighMsg()
