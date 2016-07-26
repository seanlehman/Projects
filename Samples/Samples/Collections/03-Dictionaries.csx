using System.Collections.Generic;

var myDictionary =
    new Dictionary<string, int>();

myDictionary.Add("Sunday", 1); // Use Add function to add items
myDictionary.Add("Monday", 2);


//myDictionary["Sunday"]
//myDictionary["Sunday"] = 7;

var myDictionary2 =
    new Dictionary<string, int>
    {
            { "Sunday", 1 },
            { "Monday", 2 }
    };

