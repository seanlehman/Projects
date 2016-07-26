
for(var x = 0; x <= 10; x++)
{
    Console.WriteLine(x);
}


// Using loop to get a list of names
/*var doctors = 
    new List<string>
{
    "Strax",
    "Rose",
    "Hurt",
    "Smith"
};

for (var x = 0; x < doctors.Count; x++)
{
    Console.WriteLine($"Name: {doctors[x]}");
}*/

// Better way to do the above loop
var doctors =
    new List<string>
{
    "Strax",
    "Rose",
    "Hurt",
    "Smith"
};

//for (var x = 0; x < doctors.Count; x++)
//{
//    var name = doctors[x];
//    Console.WriteLine($"Name: {name}");
//}


// Best way to do the loop

foreach (var name in doctors)
{
    Console.WriteLine($"Name: {name}");
}

// IEnumerable

var enumerator = doctors.GetEnumerator();
while(enumerator.MoveNext())
{
    Console.WriteLine($"Item = {enumerator.Current}");
}

foreach (var c in "Hello World")
{
    Console.WriteLine(c);
}
