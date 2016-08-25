using System;

//Use an if statement 

public int Age = 17;
if (Age >= 21)
{
Console.WriteLine("You can vote and also drink.");
}

else if (Age >= 18)
{
Console.WriteLine("You can vote.");
}

else
{
    Console.WriteLine("Sorry, you can't vote or drink.");
}

//Array of days with for loop

string[] days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

Console.WriteLine("The days of the week are:");

for (int i = 0; i <= 6; i++)
{
 Console.WriteLine(days[i]);
}


//Array of days with foreach loop

string[] days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

Console.WriteLine("The days of the week are:");

foreach (string day in days) 
{
    Console.WriteLine(day);
}
