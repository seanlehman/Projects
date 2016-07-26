
var x = 10;

if (x == 10)
{
    Console.WriteLine("x is 10");
}
else
{
    Console.WriteLine("x is not 10 or 20");
}

Console.WriteLine(x == 10 ? "x is 10" : "x is not 10"); // replaces above


object o = null;

object o2 = 0 ?? "new object"; // replaces below


//object o = null;

//object 02;
//if (o == null)
//{
//    o2 = new object();
//}
//else
//{
//    o2 = 0;
//}
