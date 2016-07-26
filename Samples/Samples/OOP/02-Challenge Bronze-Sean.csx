using System;

// Define a class that means something

public class MobilePhone
{
    private string _make;
    private string _model;


    public MobilePhone(string make, string model) //Constructor
    {
        Console.WriteLine("Creating a Phone");
        Make = make;
        Model = model;
    }

    public string Make
    {
        get { return _make; }
        set { _make = value.Trim(); }
    }

public string Model
    {
        get { return _model; }
        set { _model = value;  }
    }

    public override string ToString()
    {
        return $"{Make} {Model}";
    }
}

var p = new MobilePhone("iPhone", "6s Plus");

Console.WriteLine(p);


// object initialization syntax
var p2 = new MobilePhone("Samsung", "Galaxy");


Console.WriteLine(p2);


//var p =
//    new Person("Dave", "Fancher")
//    {
//        MiddleInitial = 'W'
//    };

//    p.MiddleInitial = 'W';

//Console.WriteLine(p);

//// Inheritance

//public class Student  // 'Student' is a 'Person'
//    : Person
//{
//    public Student(
//        string firstName, 
//        string lastName)
//           : base(firstName, lastName)
//    {
//        Console.WriteLine("Creating a Student");
//        StudentId = studentId;
//    }


//    public int StudentId { get; set;  }

//    public override string ToString()
//    {
//        return $"{base.ToString()} [{StudentId}]";
//    }

//}

//var s = new Student(1, "Nadia", "Fancher");

//string WhatIsIt(object o)
//{
//    if (o is Student) return "Student";
//    if (o is Person) return "Person";
//      if (o is 
//}
