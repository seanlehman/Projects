using System;
using System.Linq

// Gold Challenge to Use LINQ to transform the sequence of integers from 1 to 100 to a sequence of FizzBuzz values using the function from the previous challenge.
//  and Print the resulting sequence to the console.

string GetFizzBuzzValue(int i)
{
    if (i % 15 == 0) // put at top, otherwise loop will go to next integer
    {
        return "FizzBuzz";
    }
    else if (i % 3 == 0)
    {
        return "Fizz";
    }

    else if (i % 5 == 0)
    {
        return "Buzz";
    }
    
    {
        return i.ToString();
    }
}
// function to count from 1-100

void FizzBuzz()
{
    for(var i = 1; i <=100; i++)
    {
        var fb = GetFizzBuzzValue(1);
        Console.WriteLine(fb);           
    }
}

FizzBuzz();

// Enumerable uses the above code/functions

Enumerable
    .Range(1, 100) //Returns Range from 1-100
    .Select(GetFizzBuzzValue)// 'Select' knows the method, Method accepts the function
    .ToList()// Puts the values in a list
    .ForEach(Console.WriteLine); //Prints the value to the screen
