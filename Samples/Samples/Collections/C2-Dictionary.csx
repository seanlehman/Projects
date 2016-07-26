using System.Collections.Generic;

// Silver Challenge

var myDictionary2 =
    new Dictionary<string, int>
    {
            { "Gladiator", 2000 },
            { "A Beautiful Mind", 2001 },
            { "Chicago", 2002 },
            { "The Lord of the Rings: The Return of the King", 2003 },
            { "Million Dollar Baby", 2004 },
            { "Crash", 2005 }
    };


// Gold Challenge

var myDictionary3 =
new Dictionary<int, string[]>
{
            { 2000, new [] { "Gladiator", "Chocolat", "Crouching Tiger, Hidden Dragon", "Erin Brockovich", "Traffic" } },
            { 2001, new [] { "A Beautiful Mind", "Gosford Park", "In The Bedroom", "The Lord of the Rings: The Fellowship of the Ring", "Moulin Rouge!" } },
            { 2002, new [] { "Chicago", "Gangs of New York", "The Hours", "The Lord of the Rings: The Two Towers", "The Pianist" } },
            { 2003, new [] { "The Lord of the Rings: The Return of the King", "Lost in Translation", "Master and Commander: The Far Side of the World", "Mystic River", "Seabiscuit" } },
            { 2004, new [] { "Million Dollar Baby", "The Aviator", "Finding Neverland", "Ray", "Sideways" } },
            { 2005, new [] { "Crash", "Brokeback Mountain", "Capote", "Good Night, and Good Luck", "Munich" }  }
};

for (int index = 0; index < myDictionary3.Count; index++)
{
    var item = myDictionary3.ElementAt(index);
    var itemKey = item.Key;
    var itemValue = myDictionary3 [itemKey];
    itemKey
}

