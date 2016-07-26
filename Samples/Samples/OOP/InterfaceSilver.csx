#r "System.Windows.Forms.dll"

using System;
using System.Windows.Forms;

public interface ILogger  //Bronze Challenge - Design the interface
{
    void LowMsg();
    void MedMsg();
    void HighMsg();
}

public class ConsoleLogger : ILogger  //Silver - 1. Define a class
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


var cl = new ConsoleLogger();  //Silver 2. Create an instance
cl.LowMsg()  //Silver 3. Execute the various interface methods
cl.MedMsg()
cl.HighMsg()
