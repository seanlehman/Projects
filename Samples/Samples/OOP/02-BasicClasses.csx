using System;

// Define a class that means something

public abstract class Person
{
    private string _firstName;
    private string _lastName;


    public Person(string firstName, string lastName) //Constructor
    {
        Console.WriteLine("Creating a Person");
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value.Trim(); }
    }

public string LastName
    {
        get { return _lastName; }
        set { _lastName = value;  }
    }

    public char MiddleInitial { get; set;  }

    public override string ToString()
    {
        return $"{LastName}, {FirstName}";
    }
}

//var p = new Person();
//p.FirstName = "Dave";
//p.LastName = "Fancher";

//// Object Initialization Syntax
//var p2 =
//    new Person
//    {
//        FirstName = "Dave",
//        LastName = "Fancher"
//    };

var p =
    new Person("Dave", "Fancher")
    {
        MiddleInitial = 'W'
    };

    p.MiddleInitial = 'W';

Console.WriteLine(p);

// Inheritance

public class Student  // 'Student' is a 'Person'
    : Person
{
    public Student(
        string firstName, 
        string lastName)
           : base(firstName, lastName)
    {
        Console.WriteLine("Creating a Student");
        StudentId = studentId;
    }


    public int StudentId { get; set;  }

    public override string ToString()
    {
        return $"{base.ToString()} [{StudentId}]";
    }

}

var s = new Student(1, "Nadia", "Fancher");

//string WhatIsIt(object o)
//{
//    if (o is Student) return "Student";
//    if (o is Person) return "Person";
//      if (o is 
//}
