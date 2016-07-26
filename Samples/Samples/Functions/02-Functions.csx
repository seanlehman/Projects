using System;

// (int, int) -> int  Function parameter should return same type of parameter

int AddTwoIntegers(int a, int b)
{
    var sum = a + b;
    return sum;
}

var sum = AddTwoIntegers(5, 10); // Return result of invoking the function

Console.WriteLine(sum);

