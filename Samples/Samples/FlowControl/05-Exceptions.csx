using System;
using System.Text;

// Building functions

//How to reverse a string
public string Reverse(string str)
{
    var reversed = new StringBuilder();

    for(var p = str.Length -1; p >= 0; p--)
    {
        reversed.Append(str[p]);
    }

    return reversed.ToString();
}

// debug check in c# Interactive
try
{
    var reversed = Reverse("Null");
    Console.WriteLine(reversed);
}
catch(NullReferenceException ex)
{
    Console.WriteLine($"An error occurred {ex}");
}