using System;
using System.Collections.Generic;

public class MobilePhone
{
    public MobilePhone(string make, string model, string manufacturer)
    {
        Make = make;
        Model = model;
    }
    public string Make { get; set; }
    public string Model { get; set; }
    //public string Manufacturer { get; set; }

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

public class SamsungPhone
    : MobilePhone
{

    public SamsungPhone(string make, string model)
        : base(make, model, "Samsung")
    {
        if(model != "Note 5" && model != "Edge 5")
        {
            throw new ArgumentException("Unrecognized model");

        }
    }
}

var myPhone2 = new SamsungPhone("Galaxy", "Note 4");


