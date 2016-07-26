using System;

//Function to write something to the console

void SayHello()  //Signature - accepts nothing
{
    Console.WriteLine("Hello, World!");
}

void SayHello(string name)  //Signature - returns something
{
    Console.WriteLine($"Hello, {name}!");
}

SayHello();

var name = "Dave";
SayHello(name);


