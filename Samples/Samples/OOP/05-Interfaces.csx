#r "System.Windows.Forms.dll"

using System;
using System.Windows.Forms;

public interface IGreeter //I = Interface
{
    void SayHello(string name); //need semicolon, don't provide functionality
}

public class ConsoleGreeter
    : IGreeter
{
    public void SayGoodbye(string name)
    {
        Console.WriteLine("Goodbye");
    }

    void IGreeter.SayHello(string name)
    {
        Console.WriteLine($"Goodbye, {name}");
    }
}

public class WindowsGreeter
    : IGreeter
{
    void IGreeter.SayHello(string name)
    {
        MessageBox.Show($"Hello, {name}", "Greetings!");
    }
}

public class Person
{
    private readonly IGreeter _greeter;

    public Person(IGreeter greeter)
    {
        _greeter = greeter;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public void Greet(IGreeter greeter)
    {
       greeter.SayHello($"{FirstName} {LastName}");
    }
}


var p = new Person {  FirstName = "Pikachu"},


public interface

public class RealDateTimeService
    :IDateTimeService
{
    public DateTime GetCurrentLocalTime()
    {
        return DateTime.Now;
    }
}


public class FakeDateTimeService
    : IDateTimeService
{

}
var cg = new ConsoleGreeter();
//cg.SayHello("Dave");

IGreeter wg = new WindowsGreeter();
//wg.SayHello("Pikachu");

