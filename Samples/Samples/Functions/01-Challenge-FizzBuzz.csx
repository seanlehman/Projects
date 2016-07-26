using System;

// function to count from 1-100

void FizzBuzz()
{
    for(var i = 1; i <=100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0) // put at top, otherwise loop will go to next integer
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }

        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
            
    }
}

FizzBuzz();
