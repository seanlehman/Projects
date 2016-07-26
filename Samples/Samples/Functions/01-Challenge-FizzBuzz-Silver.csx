using System;

//Silver Challenge to Extract the FizzBuzz logic to a
//separate function that returns the appropriate string
//    for a given integer.
//  and Revise the original function to invoke the new
//function.

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
