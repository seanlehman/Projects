using System.Collections;
using System.Collections.Generic;

var names = new[] { "Dave", "Sean", "Freda", "Fred" };

//Create a new list - Specific
//var namesStartingWithD = new List<string>();

//foreach(var name in names)
//{
//    if (name.StartsWith("D"))
//    {
//        namesStartingWithD.Add(name);
//    }
//}

//var namesStartingWithJ = new List<string>();

//foreach (var name in names)
//{
//    if (name.StartsWith("J"))
//    {
//        namesStartingWithD.Add(name);
//    }
//};

// Create a new list - Global

IEnumerable<string> GetNamesStartingWith(
    IEnumerable<string> names,
    string startingWith)
{
    var result = new List<string>();

    foreach(var name in names)
    {
        if(name.StartsWith(startingWith))
        {
            result.Add(name);
        }
    }
    return result;
}

var namesStartingWithD =
    GetNamesStartingWith(names, "D");

var namesStartingWithF =
    GetNamesStartingWith(names, "F");

var namesStartingWithS =
    GetNamesStartingWith(names, "S");


