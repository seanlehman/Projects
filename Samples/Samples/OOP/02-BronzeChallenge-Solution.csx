using System;
using System.Collections.Generic;

public abstract class MobilePhone
{
    public MobilePhone(string make, string model, string manufacturer)
    {
        Make = make;
        Model = model;
    }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Manufacturer { get; set; }

    public override string ToString()
    {
        return $"{Make} {Model}";
    }
}

var myPhone = new MobilePhone("Galaxy", "Note5");
Console.WriteLine(myPhone);


//// Dictionary
//var phones = 
//    new Dictionary<string, MobilePhone>
//    {
//        { "Kevin", new MobilePhone("iPhone", "6") },
//        {"Esther", new MobilePhone("Lumia", "920") }
//    }

//foreach(EnvironmentVariableTarget p in phones)
//    {
//    Console.WriteLine($"{p.Key}: {p.Value}");
//    }

